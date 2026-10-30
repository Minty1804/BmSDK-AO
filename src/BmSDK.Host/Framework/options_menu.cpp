// In-game options menu (see options_menu.h). The DX11/ImGui part follows Ultimate UI AO's menu.cpp
// (same author, MIT): swapchain vtable slots instead of inline hooks, menu key handled in the window procedure.
#include "options_menu.h"
#include "ao_boot.h"

#include <Windows.h>
#include <d3d11.h>
#include <dxgi.h>

#include <algorithm>
#include <atomic>
#include <cfloat>
#include <cmath>
#include <limits>
#include <mutex>
#include <string>
#include <utility>
#include <vector>

#include <imgui.h>
#include <imgui_impl_dx11.h>
#include <imgui_impl_win32.h>

#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "dxgi.lib")

extern IMGUI_IMPL_API LRESULT ImGui_ImplWin32_WndProcHandler(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);

namespace {
    struct Option {
        int id;
        std::string tab, section, group, label, help, format;
        std::vector<std::string> choices, choiceTips;  // choice: names and their tooltips
        int type;    // 0 bool, 1 int, 2 float, 3 choice, 4 colour (0xRRGGBB), 5 text
        int flags;   // BMSDK_MENU_ADVANCED: inside the section's "Advanced" node
        int parent;  // bool option it depends on (0 = none): indented, disabled while that one is off
        double min, max, def, value;
        std::string text, defText;  // text options
        std::string status;
        int statusState = 0;  // 0 info, 1 ok, 2 warning, 3 error
        bool dirty = false;   // changed in the menu since the last BmSDK_Menu_PollChanges
        bool held = false;    // its slider is being dragged (menu copy only)
    };

    std::mutex g_lock;  // g_options, g_tabs, g_ui
    std::vector<Option> g_options;
    std::vector<std::string> g_tabs;  // in the order mods registered them; "BmSDK" is drawn last
    std::string g_ui[4] = {"", "Reset to defaults", "No loaded mod declares options.", "Advanced"};
    int g_nextId = 1;
    std::atomic<unsigned> g_generation{0};
    unsigned g_tableVersion = 1;    // bumped (under g_lock) when the table changes other than by a menu edit
    std::atomic<int> g_activeId{0};  // option whose slider is being dragged, 0 = none
    std::atomic<bool> g_showStatus{false};

    using PresentFn = HRESULT(STDMETHODCALLTYPE*)(IDXGISwapChain*, UINT, UINT);
    using ResizeFn = HRESULT(STDMETHODCALLTYPE*)(IDXGISwapChain*, UINT, UINT, UINT, DXGI_FORMAT, UINT);
    PresentFn g_origPresent = nullptr;
    ResizeFn g_origResize = nullptr;
    WNDPROC g_origWndProc = nullptr;
    HWND g_hwnd = nullptr;
    ID3D11Device* g_dev = nullptr;
    ID3D11DeviceContext* g_ctx = nullptr;
    ID3D11RenderTargetView* g_rtv = nullptr;
    bool g_imgui = false, g_failed = false;
    std::atomic<bool> g_installed{false};
    std::atomic<bool> g_open{false};
    std::atomic<int> g_key{VK_F10};
    std::atomic<DWORD> g_lastToggle{0};

    void toggle() {  // WndProc and the Present-side polling may both see one press: the first one wins
        if (GetTickCount() - g_lastToggle < 300) return;
        g_open = !g_open;
        g_lastToggle = GetTickCount();
        ao_boot::log("[menu] %s", g_open ? "open" : "closed");
    }

    bool is_input(UINT msg) {
        return (msg >= WM_MOUSEFIRST && msg <= WM_MOUSELAST) || (msg >= WM_KEYFIRST && msg <= WM_KEYLAST) || msg == WM_INPUT;
    }

    LRESULT CALLBACK wnd_proc(HWND h, UINT msg, WPARAM w, LPARAM l) {
        // The menu key never reaches the game: almost every key has a game binding (BmInput.ini: F8 = "Fov 100"...).
        const int key = g_key;
        if ((msg == WM_KEYDOWN || msg == WM_SYSKEYDOWN || msg == WM_KEYUP || msg == WM_SYSKEYUP) && int(w) == key) {
            if ((msg == WM_KEYDOWN || msg == WM_SYSKEYDOWN) && !(l & (1 << 30)) && g_imgui) toggle();
            return 0;
        }
        // A bare F10 opens the window's menu bar loop in DefWindowProc and freezes the game for a moment
        if (key == VK_F10 && msg == WM_SYSCOMMAND && (w & 0xFFF0) == SC_KEYMENU && l == 0) return 0;
        if (g_open && g_imgui) {
            ImGui_ImplWin32_WndProcHandler(h, msg, w, l);
            if (is_input(msg)) return 0;  // the game does not see it while the menu is open
        }
        return CallWindowProcW(g_origWndProc, h, msg, w, l);
    }

    bool init(IDXGISwapChain* sc) {
        DXGI_SWAP_CHAIN_DESC d{};
        if (FAILED(sc->GetDesc(&d)) || !d.OutputWindow) return false;
        if (FAILED(sc->GetDevice(__uuidof(ID3D11Device), reinterpret_cast<void**>(&g_dev))) || !g_dev) return false;
        g_dev->GetImmediateContext(&g_ctx);
        g_hwnd = d.OutputWindow;
        ImGui::CreateContext();
        ImGuiIO& io = ImGui::GetIO();
        io.IniFilename = nullptr;
        io.ConfigFlags |= ImGuiConfigFlags_NavEnableKeyboard | ImGuiConfigFlags_NavEnableGamepad;
        ImGui::StyleColorsDark();
        ImGuiStyle& st = ImGui::GetStyle();
        st.WindowRounding = 6.f;
        st.FrameRounding = 4.f;
        const float scale = (std::max)(1.f, float(d.BufferDesc.Height) / 1080.f);
        st.ScaleAllSizes(scale);
        io.FontGlobalScale = scale * 1.15f;
        if (!ImGui_ImplWin32_Init(g_hwnd) || !ImGui_ImplDX11_Init(g_dev, g_ctx)) return false;
        g_origWndProc = reinterpret_cast<WNDPROC>(SetWindowLongPtrW(g_hwnd, GWLP_WNDPROC, reinterpret_cast<LONG_PTR>(wnd_proc)));
        ao_boot::log("[menu] ImGui ready on %ux%u window %p", d.BufferDesc.Width, d.BufferDesc.Height, g_hwnd);
        return true;
    }

    ImVec4 status_color(int state) {
        switch (state) {
            case 1: return ImVec4(0.45f, 0.85f, 0.45f, 1.f);
            case 2: return ImVec4(0.95f, 0.8f, 0.3f, 1.f);
            case 3: return ImVec4(0.95f, 0.4f, 0.4f, 1.f);
            default: return ImGui::GetStyleColorVec4(ImGuiCol_TextDisabled);
        }
    }

    void help_marker(const Option& o) {
        if (o.help.empty()) return;
        ImGui::SetItemTooltip("%s", o.help.c_str());
        ImGui::SameLine();
        ImGui::TextDisabled("(?)");
        ImGui::SetItemTooltip("%s", o.help.c_str());
    }

    struct Edit {
        int id;
        double value;
        std::string text;
    };

    // Text being typed per option: InputText needs a buffer that lives across frames.
    struct TextEdit {
        int id;
        std::string buf;
        bool editing;
    };
    std::vector<TextEdit> s_textEdit;
    TextEdit& text_edit(const Option& o) {
        for (auto& t : s_textEdit)
            if (t.id == o.id) return t;
        s_textEdit.push_back({o.id, o.text, false});
        return s_textEdit.back();
    }

    // Draws one option on the menu's copy; records an edit if the user changed it.
    void option_row(Option& o, std::vector<Edit>& edits) {
        ImGui::PushID(o.id);
        const float width = ImGui::GetFontSize() * 14.f;
        bool changed = false;
        switch (o.type) {
            case 0: {
                bool v = o.value != 0;
                if ((changed = ImGui::Checkbox(o.label.c_str(), &v))) o.value = v ? 1 : 0;
                o.held = false;
                help_marker(o);
                break;
            }
            case 1: {
                int v = int(o.value);
                ImGui::SetNextItemWidth(width);
                const char* fmt = o.format.empty() ? "%d" : o.format.c_str();
                if ((changed = ImGui::SliderInt(o.label.c_str(), &v, int(o.min), int(o.max), fmt, ImGuiSliderFlags_AlwaysClamp)))
                    o.value = v;
                o.held = ImGui::IsItemActive();
                help_marker(o);
                break;
            }
            case 2: {
                float v = float(o.value);
                ImGui::SetNextItemWidth(width);
                const char* fmt = !o.format.empty() ? o.format.c_str() : (o.max - o.min) <= 2.0 ? "%.3f" : "%.2f";
                // Values are rounded to the shown precision, so a drag produces fewer distinct values
                if ((changed = ImGui::SliderFloat(o.label.c_str(), &v, float(o.min), float(o.max), fmt, ImGuiSliderFlags_AlwaysClamp)))
                    o.value = v;
                o.held = ImGui::IsItemActive();
                help_marker(o);
                break;
            }
            case 3: {
                int v = int(o.value);
                if (o.choices.size() <= 5) {  // few choices: a row of radio buttons, each with its own tooltip
                    ImGui::TextUnformatted(o.label.c_str());
                    if (!o.help.empty()) ImGui::SetItemTooltip("%s", o.help.c_str());
                    for (int i = 0; i < int(o.choices.size()); i++) {
                        ImGui::SameLine();
                        if (ImGui::RadioButton(o.choices[i].c_str(), v == i) && v != i) {
                            v = i;
                            changed = true;
                        }
                        if (i < int(o.choiceTips.size()) && !o.choiceTips[i].empty()) ImGui::SetItemTooltip("%s", o.choiceTips[i].c_str());
                    }
                } else {
                    ImGui::SetNextItemWidth(width);
                    const char* preview = v >= 0 && v < int(o.choices.size()) ? o.choices[v].c_str() : "";
                    // Drop-down list up to 16 items tall (ImGui's default is 8): long lists like a suit list
                    const ImGuiStyle& st = ImGui::GetStyle();
                    ImGui::SetNextWindowSizeConstraints(ImVec2(0, 0),
                        ImVec2(FLT_MAX, (ImGui::GetFontSize() + st.ItemSpacing.y) * 16 - st.ItemSpacing.y + st.WindowPadding.y * 2));
                    if (ImGui::BeginCombo(o.label.c_str(), preview)) {
                        for (int i = 0; i < int(o.choices.size()); i++) {
                            if (ImGui::Selectable(o.choices[i].c_str(), v == i) && v != i) {
                                v = i;
                                changed = true;
                            }
                            if (i < int(o.choiceTips.size()) && !o.choiceTips[i].empty()) ImGui::SetItemTooltip("%s", o.choiceTips[i].c_str());
                        }
                        ImGui::EndCombo();
                    }
                    help_marker(o);
                }
                if (changed) o.value = v;
                o.held = false;
                break;
            }
            case 4: {
                const unsigned rgb = unsigned(o.value);
                float c[3] = {float((rgb >> 16) & 0xFF) / 255.f, float((rgb >> 8) & 0xFF) / 255.f, float(rgb & 0xFF) / 255.f};
                ImGui::SetNextItemWidth(width);
                if ((changed = ImGui::ColorEdit3(o.label.c_str(), c))) {
                    auto b = [](float f) { return unsigned(std::lround(std::clamp(f, 0.f, 1.f) * 255.f)); };
                    o.value = double((b(c[0]) << 16) | (b(c[1]) << 8) | b(c[2]));
                }
                o.held = ImGui::IsItemActive();  // the picker popup counts as a drag
                help_marker(o);
                break;
            }
            default: {
                TextEdit& te = text_edit(o);
                if (!te.editing) te.buf = o.text;  // not being typed in: show the current value
                std::string& buf = te.buf;
                char tmp[256];
                strncpy_s(tmp, buf.c_str(), _TRUNCATE);
                ImGui::SetNextItemWidth(ImGui::GetFontSize() * 22.f);
                if (ImGui::InputText(o.label.c_str(), tmp, sizeof(tmp))) buf = tmp;
                te.editing = ImGui::IsItemActive();
                if (ImGui::IsItemDeactivatedAfterEdit() && buf != o.text) {
                    o.text = buf;
                    edits.push_back({o.id, 0, o.text});
                }
                o.held = false;
                help_marker(o);
                break;
            }
        }
        if (changed) edits.push_back({o.id, o.value, {}});
        if (!o.status.empty() && (o.statusState >= 2 || g_showStatus)) {
            ImGui::Indent();
            ImGui::TextColored(status_color(o.statusState), "%s", o.status.c_str());
            ImGui::Unindent();
        }
        ImGui::PopID();
    }

    // Draws from a copy of the table, so a fault inside ImGui never leaves g_lock held (the game thread uses it).
    // The copy is refreshed only when the table changes, not every frame: menu edits go to both.
    std::vector<Option> s_view;
    std::vector<std::string> s_viewTabs;
    std::string s_viewUi[4];
    unsigned s_viewVersion = 0;

    const Option* view_option(int id) {
        for (const auto& o : s_view)
            if (o.id == id) return &o;
        return nullptr;
    }

    // Options of one tab and section: groups with a title, then the advanced ones in a collapsed node.
    void draw_list(const std::string& tab, const std::string& section, std::vector<Edit>& edits, int& active) {
        for (int pass = 0; pass < 2; pass++) {
            const bool advanced = pass == 1;
            bool any = false;
            for (const auto& o : s_view)
                any = any || (o.tab == tab && o.section == section && ((o.flags & BMSDK_MENU_ADVANCED) != 0) == advanced);
            if (!any) continue;
            if (advanced && !ImGui::TreeNode((s_viewUi[3] + "##adv").c_str())) continue;
            const std::string* group = nullptr;
            for (auto& o : s_view) {
                if (o.tab != tab || o.section != section || ((o.flags & BMSDK_MENU_ADVANCED) != 0) != advanced) continue;
                if (!o.group.empty() && (!group || *group != o.group)) ImGui::SeparatorText(o.group.c_str());
                group = &o.group;
                const Option* parent = o.parent ? view_option(o.parent) : nullptr;
                if (parent) {
                    ImGui::Indent();
                    ImGui::BeginDisabled(parent->value == 0);
                }
                option_row(o, edits);
                if (parent) {
                    ImGui::EndDisabled();
                    ImGui::Unindent();
                }
                if (o.held) active = o.id;
            }
            if (advanced) ImGui::TreePop();
        }
    }

    void draw_tab(const std::string& tab, std::vector<Edit>& edits, int& active) {
        draw_list(tab, "", edits, active);
        std::vector<std::string> sections;
        for (const auto& o : s_view)
            if (o.tab == tab && !o.section.empty() && std::find(sections.begin(), sections.end(), o.section) == sections.end())
                sections.push_back(o.section);
        if (!sections.empty() && ImGui::BeginTabBar(("sections##" + tab).c_str())) {
            for (const auto& sec : sections) {
                if (!ImGui::BeginTabItem(sec.c_str())) continue;
                draw_list(tab, sec, edits, active);
                ImGui::EndTabItem();
            }
            ImGui::EndTabBar();
        }
        ImGui::Spacing();
        if (ImGui::SmallButton(s_viewUi[1].c_str())) {
            for (auto& o : s_view) {
                if (o.tab != tab) continue;
                if (o.type == 5 && o.text != o.defText) {
                    o.text = o.defText;
                    edits.push_back({o.id, 0, o.text});
                } else if (o.type != 5 && o.value != o.def) {
                    o.value = o.def;
                    edits.push_back({o.id, o.def, {}});
                }
            }
        }
    }

    void draw_menu() {
        {
            std::lock_guard<std::mutex> lock(g_lock);
            if (s_viewVersion != g_tableVersion) {
                s_view = g_options;
                s_viewTabs = g_tabs;
                for (int i = 0; i < 4; i++) s_viewUi[i] = g_ui[i];
                s_viewVersion = g_tableVersion;
            }
        }
        std::vector<Edit> edits;
        int active = 0;

        const ImVec2 screen = ImGui::GetIO().DisplaySize;
        // Top right, so it does not cover Ultimate UI's own window (top left) while it is still an .asi
        ImGui::SetNextWindowPos(ImVec2(screen.x - 60.f, 60.f), ImGuiCond_FirstUseEver, ImVec2(1.f, 0.f));
        ImGui::SetNextWindowSizeConstraints(ImVec2(0, 0), ImVec2(FLT_MAX, screen.y > 200 ? screen.y - 120 : FLT_MAX));
        ImGui::Begin("BmSDK", nullptr, ImGuiWindowFlags_NoCollapse | ImGuiWindowFlags_AlwaysAutoResize);
        std::vector<std::string> order;
        for (const auto& t : s_viewTabs)
            if (t != "BmSDK") order.push_back(t);
        if (std::find(s_viewTabs.begin(), s_viewTabs.end(), "BmSDK") != s_viewTabs.end()) order.push_back("BmSDK");
        if (order.size() == (order.empty() || order.back() != "BmSDK" ? 0u : 1u)) ImGui::TextDisabled("%s", s_viewUi[2].c_str());
        if (!order.empty() && ImGui::BeginTabBar("mods")) {
            for (const auto& tab : order) {
                if (!ImGui::BeginTabItem(tab.c_str())) continue;
                draw_tab(tab, edits, active);
                ImGui::EndTabItem();
            }
            ImGui::EndTabBar();
        }
        if (!s_viewUi[0].empty()) {
            ImGui::Separator();
            ImGui::TextDisabled("%s", s_viewUi[0].c_str());
        }
        ImGui::End();
        g_activeId = active;

        if (!edits.empty()) {
            std::lock_guard<std::mutex> lock(g_lock);
            for (const auto& e : edits) {
                for (auto& o : g_options) {
                    if (o.id != e.id) continue;
                    if (o.type == 5) o.text = e.text;
                    else o.value = e.value;
                    o.dirty = true;
                }
            }
            g_generation++;
        }
    }

    bool key_edge(int vk) {
        static bool down = false;
        const bool now = (GetAsyncKeyState(vk) & 0x8000) != 0;
        const bool edge = now && !down;
        down = now;
        return edge;
    }

    void release_rtv() {
        if (g_rtv) g_rtv->Release();
        g_rtv = nullptr;
    }

    void render(IDXGISwapChain* sc) {
        if (!g_imgui && !(g_imgui = init(sc))) {
            g_failed = true;
            ao_boot::log("[menu] ImGui init failed: no menu");
            return;
        }
        // Backup for key presses that never arrive as window messages
        if (key_edge(g_key) && GetForegroundWindow() == g_hwnd) toggle();
        ImGui::GetIO().MouseDrawCursor = g_open;
        if (!g_open) {
            g_activeId = 0;  // closed in the middle of a drag
            return;
        }
        if (!g_rtv) {
            ID3D11Texture2D* bb = nullptr;
            if (SUCCEEDED(sc->GetBuffer(0, __uuidof(ID3D11Texture2D), reinterpret_cast<void**>(&bb))) && bb) {
                g_dev->CreateRenderTargetView(bb, nullptr, &g_rtv);
                bb->Release();
            }
        }
        ImGui_ImplDX11_NewFrame();
        ImGui_ImplWin32_NewFrame();
        ImGui::NewFrame();
        draw_menu();
        ImGui::Render();
        if (g_rtv) {
            ID3D11RenderTargetView* oldRtv = nullptr;
            ID3D11DepthStencilView* oldDsv = nullptr;
            g_ctx->OMGetRenderTargets(1, &oldRtv, &oldDsv);
            g_ctx->OMSetRenderTargets(1, &g_rtv, nullptr);
            ImGui_ImplDX11_RenderDrawData(ImGui::GetDrawData());
            g_ctx->OMSetRenderTargets(1, &oldRtv, oldDsv);
            if (oldRtv) oldRtv->Release();
            if (oldDsv) oldDsv->Release();
        }
    }

    void guarded_render(IDXGISwapChain* sc) {
        __try {
            render(sc);
        } __except (EXCEPTION_EXECUTE_HANDLER) {
            g_failed = true;
            ao_boot::log("[menu] exception in Present: menu disabled");
        }
    }

    HRESULT STDMETHODCALLTYPE present(IDXGISwapChain* sc, UINT sync, UINT flags) {
        if (!g_failed) guarded_render(sc);
        return g_origPresent(sc, sync, flags);
    }

    HRESULT STDMETHODCALLTYPE resize(IDXGISwapChain* sc, UINT n, UINT w, UINT h, DXGI_FORMAT f, UINT fl) {
        release_rtv();
        return g_origResize(sc, n, w, h, f, fl);
    }

    bool swapchain_vtable(void*** out) {
        WNDCLASSEXW wc{sizeof(wc)};
        wc.lpfnWndProc = DefWindowProcW;
        wc.hInstance = GetModuleHandleW(nullptr);
        wc.lpszClassName = L"BmSDKMenuDummy";
        RegisterClassExW(&wc);
        HWND w = CreateWindowExW(0, wc.lpszClassName, L"", WS_OVERLAPPED, 0, 0, 64, 64, nullptr, nullptr, wc.hInstance, nullptr);
        if (!w) return false;
        DXGI_SWAP_CHAIN_DESC sd{};
        sd.BufferCount = 1;
        sd.BufferDesc.Width = sd.BufferDesc.Height = 64;
        sd.BufferDesc.Format = DXGI_FORMAT_R8G8B8A8_UNORM;
        sd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
        sd.OutputWindow = w;
        sd.SampleDesc.Count = 1;
        sd.Windowed = TRUE;
        IDXGISwapChain* sc = nullptr;
        ID3D11Device* dev = nullptr;
        ID3D11DeviceContext* ctx = nullptr;
        D3D_FEATURE_LEVEL fl;
        const HRESULT hr = D3D11CreateDeviceAndSwapChain(nullptr, D3D_DRIVER_TYPE_HARDWARE, nullptr, 0, nullptr, 0,
                                                         D3D11_SDK_VERSION, &sd, &sc, &dev, &fl, &ctx);
        const bool ok = SUCCEEDED(hr) && sc;
        if (ok) *out = *reinterpret_cast<void***>(sc);  // shared by every swapchain of this class (lives in dxgi.dll)
        if (ctx) ctx->Release();
        if (sc) sc->Release();
        if (dev) dev->Release();
        DestroyWindow(w);
        UnregisterClassW(wc.lpszClassName, wc.hInstance);
        return ok;
    }

    bool patch_slot(void** slot, void* fn, void** orig) {
        DWORD old = 0;
        if (!VirtualProtect(slot, sizeof(void*), PAGE_READWRITE, &old)) return false;
        *orig = *slot;
        *slot = fn;
        VirtualProtect(slot, sizeof(void*), old, &old);
        return true;
    }

    Option* find(int id) {
        for (auto& o : g_options) {
            if (o.id == id) return &o;
        }
        return nullptr;
    }
}

int __cdecl BmSDK_Menu_ApiVersion() { return 3; }

int __cdecl BmSDK_Menu_Install(int menuKeyVk) {
    static std::mutex installLock;
    std::lock_guard<std::mutex> lock(installLock);
    if (menuKeyVk > 0 && menuKeyVk < 256) g_key = menuKeyVk;
    if (g_installed) return 1;
    // Slots replaced instead of an inline hook on dxgi's Present: overlays (RivaTuner, Steam) re-assert their own
    // inline patch there. If Ultimate UI patched the slots first, we chain in front of it.
    void** vt = nullptr;
    if (!swapchain_vtable(&vt)) {
        ao_boot::log("[menu] could not create the dummy swapchain: no in-game menu");
        return 0;
    }
    if (!patch_slot(&vt[8], reinterpret_cast<void*>(&present), reinterpret_cast<void**>(&g_origPresent)) ||
        !patch_slot(&vt[13], reinterpret_cast<void*>(&resize), reinterpret_cast<void**>(&g_origResize))) {
        ao_boot::log("[menu] could not patch the swapchain vtable");
        return 0;
    }
    g_installed = true;
    ao_boot::log("[menu] Present hooked (vtable %p, previous %p), key 0x%02X", vt, g_origPresent, int(g_key));
    return 1;
}

void __cdecl BmSDK_Menu_SetKey(int menuKeyVk) {
    if (menuKeyVk > 0 && menuKeyVk < 256) g_key = menuKeyVk;
}

namespace {
    std::string str(const char* s) { return s ? s : ""; }

    // "a\nb\nc" -> {a, b, c}; each item may carry a tooltip after a tab: "Minimal\tRemoves the clutter".
    void split_choices(const char* list, std::vector<std::string>& names, std::vector<std::string>& tips) {
        const std::string all = str(list);
        size_t pos = 0;
        while (pos <= all.size() && !all.empty()) {
            size_t end = all.find('\n', pos);
            if (end == std::string::npos) end = all.size();
            const std::string item = all.substr(pos, end - pos);
            const size_t tab = item.find('\t');
            names.push_back(item.substr(0, tab));
            tips.push_back(tab == std::string::npos ? "" : item.substr(tab + 1));
            pos = end + 1;
        }
    }

    int add_option(Option o) {
        std::lock_guard<std::mutex> lock(g_lock);
        o.id = g_nextId++;
        if (std::find(g_tabs.begin(), g_tabs.end(), o.tab) == g_tabs.end()) g_tabs.push_back(o.tab);
        g_options.push_back(std::move(o));
        ++g_tableVersion;
        return g_options.back().id;
    }
}

int __cdecl BmSDK_Menu_AddOption(const char* tab, const char* label, const char* help, int type, double min,
                                 double max, double defaultValue, double value) {
    if (!tab || !label || type < 0 || type > 2) return 0;
    Option o{};
    o.tab = tab;
    o.label = label;
    o.help = str(help);
    o.type = type;
    o.min = min, o.max = max, o.def = defaultValue, o.value = value;
    return add_option(std::move(o));
}

int __cdecl BmSDK_Menu_AddOptionEx(const BmSDK_MenuOptionDesc* d) {
    if (!d || !d->tab || !d->label || d->type < 0 || d->type > 5) return 0;
    Option o{};
    o.tab = d->tab;
    o.section = str(d->section);
    o.group = str(d->group);
    o.label = d->label;
    o.help = str(d->help);
    o.format = str(d->format);
    o.type = d->type;
    o.flags = d->flags;
    o.parent = d->parentId;
    o.min = d->min, o.max = d->max, o.def = d->defaultValue, o.value = d->value;
    o.text = str(d->text);
    o.defText = str(d->defaultText);
    split_choices(d->choices, o.choices, o.choiceTips);
    return add_option(std::move(o));
}

void __cdecl BmSDK_Menu_RemoveTab(const char* tab) {
    if (!tab) return;
    std::lock_guard<std::mutex> lock(g_lock);
    const std::string t = tab;
    std::erase_if(g_options, [&](const Option& o) { return o.tab == t; });
    std::erase(g_tabs, t);
    ++g_tableVersion;
}

unsigned __cdecl BmSDK_Menu_Generation() { return g_generation; }

double __cdecl BmSDK_Menu_GetValue(int id) {
    std::lock_guard<std::mutex> lock(g_lock);
    const Option* o = find(id);
    return o ? o->value : std::numeric_limits<double>::quiet_NaN();
}

void __cdecl BmSDK_Menu_SetValue(int id, double value) {
    std::lock_guard<std::mutex> lock(g_lock);
    if (Option* o = find(id); o && o->value != value) {
        o->value = value;
        ++g_tableVersion;
    }
}

int __cdecl BmSDK_Menu_GetText(int id, char* buffer, int size) {
    std::lock_guard<std::mutex> lock(g_lock);
    const Option* o = find(id);
    if (!o) return -1;
    if (buffer && size > 0) strncpy_s(buffer, size_t(size), o->text.c_str(), _TRUNCATE);
    return int(o->text.size());
}

void __cdecl BmSDK_Menu_SetText(int id, const char* text) {
    std::lock_guard<std::mutex> lock(g_lock);
    if (Option* o = find(id); o && o->text != str(text)) {
        o->text = str(text);
        ++g_tableVersion;
    }
}

void __cdecl BmSDK_Menu_SetStatus(int id, const char* text, int state) {
    std::lock_guard<std::mutex> lock(g_lock);
    if (Option* o = find(id); o && (o->status != str(text) || o->statusState != state)) {
        o->status = str(text);
        o->statusState = state;
        ++g_tableVersion;
    }
}

void __cdecl BmSDK_Menu_SetShowStatus(int show) { g_showStatus = show != 0; }

int __cdecl BmSDK_Menu_PollChanges(int* ids, double* values, int max) {
    if (!ids || !values || max <= 0) return 0;
    std::lock_guard<std::mutex> lock(g_lock);
    int n = 0;
    for (auto& o : g_options) {
        if (!o.dirty || n >= max) continue;
        o.dirty = false;
        ids[n] = o.id;
        values[n] = o.value;
        ++n;
    }
    return n;
}

int __cdecl BmSDK_Menu_ActiveOption() { return g_activeId; }

int __cdecl BmSDK_Menu_IsOpen() { return g_open ? 1 : 0; }

void __cdecl BmSDK_Menu_SetFooter(const char* text) { BmSDK_Menu_SetUiText(0, text); }

void __cdecl BmSDK_Menu_SetUiText(int which, const char* text) {
    if (which < 0 || which > 3) return;
    std::lock_guard<std::mutex> lock(g_lock);
    g_ui[which] = str(text);
    ++g_tableVersion;
}
