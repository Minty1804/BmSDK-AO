#pragma once

#include "UStruct.h"

CLASS(UState, AO_SIZE(180, 212))
class UState : public UStruct
{
	// TODO
	BYTE UNK1[AO_SIZE(72, 40)];

public:
	STATIC_CLASS("Core.State")
};

CHECK_CLASS(UState);
