using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tim hieu lop Array trong C#
            int[] numbers = new int[]{0, 2, 3, 4, 7, 8, 5, 9, 6, 1};
            string[] names = new string[] { "Thanh", "Thương", "Khoa", "Dat", "Giang", "Dien", "Man" };

            System.Array.Sort(numbers);
            System.Array.Reverse(numbers);
            //System.Array.Clear(numbers,0,numbers.Length);// F5 các phần tử 
            System.Array.IndexOf(numbers , 1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number + ",");
            }
            



        }
    }
}
