using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod3_3
{
    internal class Class2
    {
        public Func<double, bool> ResultDelegate;


        private double result;

        public Class2()
        {
            ResultDelegate = Result;
        }

        public Func<double, bool> Calc(Func<int, int, double> Method, int x, int y)
        {
            result = Method(x, y);
            return ResultDelegate;
        }

        public bool Result(double x)
        {
            this.Calc(Class1.Multiply, 9, 11);
            return this.result % 2 == 0 ? true : false;
        }
    }
}
