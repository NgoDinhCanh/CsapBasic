using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop 
            // for (khoi tao ; dieu kien ; buoc nhay )
            // {
            //   Noi dung can lap 
            // }
            // Hien thi ra cac so le <= n 
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //{
            Console.WriteLine("Nhap a <= b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum for {a} to {b} = {sum}");


        }
    }
}
