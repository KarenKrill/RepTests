#pragma once

#ifdef SOMELIB_EXPORTS
#define SOMELIB_API extern "C" __declspec(dllexport)
#else
#define SOMELIB_API extern "C" __declspec(dllimport)
#endif

namespace SomeApi
{
    SOMELIB_API int Sum(int a, int b);
}