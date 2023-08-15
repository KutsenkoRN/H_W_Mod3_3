using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod3_3
{
    public delegate void ShowHandler(bool x);

    public class Class1
    {
        public ShowHandler ShowHandler = Program.Show;

        public static double Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
