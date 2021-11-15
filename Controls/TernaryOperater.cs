using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    class TernaryOperater
    {
        static void Main()
        {
            // Toán tử 3 ngôi 
            // variable = (condition)? expressionTrue : expressionFalse ;
            int time = 12;
            string msg = default;
            //if (time < 12)
            //{
            //    msg = "Hello";
            //}
            //else
            //{
            //    msg = "Goodbye";
            //}
            // 
            msg = (time < 12) ? "Hello" : "Goodbye";

            Console.WriteLine(msg);



        }
    }
}
