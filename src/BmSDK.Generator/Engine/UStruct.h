#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, AO_SIZE(108, 172))
class UStruct : public UField
{
    BYTE UNK1[8];
    FIELD(UStruct*, SuperStruct)
        FIELD(UField*, Children)
        FIELD(WORD, PropertiesSize)
        // XeTrinityz/BmSDK-AK reads it for the array stride of structs. BmSDK-AO: this offset (+66) is not measured;
        // if PropertiesSize is really an INT here it reads 0, and StructInfo::GetAlignedSize then keeps PropertiesSize.
        FIELD(WORD, MinAlignment)

    BYTE UNK2[AO_SIZE(40, 100)];  // AO Online: UFunction.FunctionFlags still right after (+172)

public:
    STATIC_CLASS("Core.Struct")
};

class UScriptStruct : public UStruct
{
    // TODO

public:
    STATIC_CLASS("Core.ScriptStruct")
};

CHECK_CLASS(UStruct)
