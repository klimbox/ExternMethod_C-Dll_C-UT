using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcExternMethod
{
    public class ExternMethod
    {
        [DllImport(@"C:\Users\roma\source\repos\CalcuDll\Debug\CalcuDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Calc(double fNum, double sNum, char op);

    }
}
