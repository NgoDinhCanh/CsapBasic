using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class BreakContinue
    {
        static void Main()
        {
            //int N = 100;
            //for (int i = 1; i < N; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i % 10 == 0)
            //    {
            //        break;
            //    }
            //}
            for (int i = 1; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    //if (j == 5)
                    //{
                    //    break;
                    //}
                }

                Console.WriteLine();
                
            }
        }
    }
}
