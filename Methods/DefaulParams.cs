using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class DefaulParams
    {
        // Tham so mac dinh , goi phuong thuc theo ten tham so 
        static void Main()
        {
            ShowInfo(last:"Phu");
        }

        static void ShowInfo(string first = "Ngo", string last ="Canh", string mid = "Dinh")
        {
            Console.WriteLine("First name: " + first );
            Console.WriteLine("Mid name: " + mid);
            Console.WriteLine("Last name: " + last);
        }

    }
}
