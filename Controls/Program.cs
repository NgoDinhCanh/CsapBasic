using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    class Program
    {
        static void Main(string[] args)
        {
            // if - else 
            /*
             * if(dieu kien ) { do something } else {do other thing }
             */
            int dayOfWeek = 1;
            if (dayOfWeek ==1 )
            {
                Console.WriteLine(" Monday");
            }
            else if ( dayOfWeek == 2)
            {
                Console.WriteLine("Tueday");
            }
            else if (dayOfWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else
            {
                Console.WriteLine("Other day");
            }
        }
    }
}
