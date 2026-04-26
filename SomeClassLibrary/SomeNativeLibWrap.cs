using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SomeClassLibrary
{
    public static class SomeNativeLibWrap
    {
        [DllImport("SomeNativeLib", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sum(int a, int b);
    }
}
