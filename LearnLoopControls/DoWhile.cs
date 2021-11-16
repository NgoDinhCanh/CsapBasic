using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class DoWhile
    {
        static void Main()
        {
            int x = 90;
            // Vong lap nay luon thuc hien it nhat 1 lan 
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 100);
        }
    }
}
