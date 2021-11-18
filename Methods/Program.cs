using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
     * Phuong thuc trong C#
     * Dinh nghia
     * Muc dich su dung : Lam cho CT cua chung ta tai su dung lai , phan tach ro rang nhung hanh dong 
     * Cu phap tong quat : //date_type name(parameters){....}
                           //Name(tham so)
     * Kieu tra ve
     * Ex
     */
    class Program
    {
        static void Main(string[] args)
        {
            //date_type name(parameters){....}
            //Name(tham so)
            int sum = Sum(10, 10);
            ShowResult(sum);
        }

        static int Sum(int a, int b)
        {
            int Sum = a + b;
            return Sum;
        }

        static double div(int a, int b)
        {
            return 1.0 * a / b;
        }

        static bool isEvent(int n)
        {
            return (n % 2 == 0); 
        }

        static void ShowResult(int n)
        {
            Console.WriteLine(n);
        }

    }
}
