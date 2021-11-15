using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class LogicalOperater
    {
        static void Main()
        {
            // Toán tử logic || && !
            int a = 100, b = 201, c = 300;
            bool isOk = (a % 2 == 0) || (b % 2 == 0);

            Console.WriteLine(isOk );
        }
    }
}
