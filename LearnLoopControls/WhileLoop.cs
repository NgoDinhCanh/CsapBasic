using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class WhileLoop
    {
        static void Main()
        {
            // While 
            /*
             * While(dieu kien )
             * { Noi dung can lap 
             * }
             */
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sum = 0;
            //while (i < n)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}
            while (i <=n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine(sum);
        }
    }
}
