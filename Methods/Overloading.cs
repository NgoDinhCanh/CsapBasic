using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Overloading
    {
        static void Main()
        {
            // Nap chong phuong thuc
            int sum = Add(120, 120);
            float sum1 = Add(12.36f, 12);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static long Add(long a, long b)
        {
            return a + b;
        }

        static long Add(long a, long b, short c)
        {
            return a + b + c ;
        }
    }
}
