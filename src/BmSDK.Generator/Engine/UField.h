#pragma once

#include "UObject.h"

CLASS(UField, AO_SIZE(48, 52))
class UField : public UObject
{
    FIELD(UField*, Next)

public:
    STATIC_CLASS("Core.Field")
};

CHECK_CLASS(UField)
