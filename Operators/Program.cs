using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toán tử toán học + - * / % ++ --
            int a = 100, b = 200;
            float c = 100.25f;
            double d = 100.25;
            int sum = a + b;
            int sum1 = (int) (a + c);
            string msg = "Hello";
            string str = msg + (a+b);

            int x = 1, y = 2;

            Console.WriteLine(x/y);
        }
    }
}
