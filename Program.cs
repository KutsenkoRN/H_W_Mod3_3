using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod3_3
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Class1 cl1 = new Class1();
            cl1.ShowHandler = Show;
            cl1.ShowHandler(new Class2().ResultDelegate(3));
        }

        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
