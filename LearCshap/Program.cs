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
            string[] friends = new string[] {"Thanh", "Thương", "Khoa", "Dat", "Giang", "Dien", "Man"};
            // Cu phap thay doi ten trong mang 
            friends[2] = "Bieu";
            //
            string[] cars = new string[100];
            //Console.WriteLine("Do dai mang:" + friends.Length);
            //Console.WriteLine(friends[2]);
            Console.WriteLine("=========== DANH SACH ===========");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

            Console.WriteLine("=========== DANH SACH ===========");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            // Sắp xếp mảng 
            Console.WriteLine("=========== DANH SACH SAU SAP XEP ===========");
            Array.Sort(friends);
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }
        }
    }
}

