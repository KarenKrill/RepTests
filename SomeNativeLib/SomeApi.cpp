#define SOMELIB_EXPORTS

#include "pch.h"
#include "SomeApi.h"

int SomeApi::Sum(int a, int b)
{
	return a + b * 2 + 666;
}