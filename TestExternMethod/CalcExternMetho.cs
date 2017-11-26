using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TestExternMethod
{
    [TestFixture]
    public class CalcExternMetho
    {
        [DllImport(@"C:\Users\roma\source\repos\CalcuDll\Debug\CalcuDll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Calc(double fNum, double sNum, char op);
        [TestCase(7, 8, '+', 15)]
        [TestCase(5, 2, '-', 3)]
        [TestCase(2, 6, '*', 12)]
        [TestCase(14, 7, '/', 2)]
        [Test]
        public void CalcExternMethod(double fNum, double sNum, char op, double exp)
        {
            Assert.AreEqual(exp, Calc(fNum, sNum, op));
        }
    }
}
