using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearCshap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * -Mảng là gì ? dùng làm cái gì ?
             * -Khai báo , khởi tạo mảng
             * -Sử dụng mảng
             * -Duyệt mảng
             * -Vòng lặp foreach
             * -Sắp xếp mảng 
             */
            int a, b, c;
            int[] number = new int[200];
            string[] friends = new string[] {"Thanh","Thương","Khoa","Dat","Giang","Dien","Man"};
            string[] cars = new string[100];
            Console.WriteLine("Do dai mang:" + friends.Length);
            Console.WriteLine(friends[3]);

        }
    }
}
