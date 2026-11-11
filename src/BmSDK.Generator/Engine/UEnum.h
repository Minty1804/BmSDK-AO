#pragma once

#include "UField.h"

CLASS(UEnum, AO_SIZE(60, 64))
class UEnum : public UField
{
	// TODO
	FIELD(TArray<FName>, Names)

public:
	STATIC_CLASS("Core.Enum")
};

CHECK_CLASS(UEnum)
