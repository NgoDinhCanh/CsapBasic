using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class RefModifier
    {
        // ref parameter gan giong vs out parameter 
        // Bat buoc khoi tao gia tri khi dung phuong thuc 
        static void Main()
        {
            //Ref Parameter Bat buoc phai khoi tao bien 
            string name="";
            int age = 0;
            float mark = 10;

            GetUserInfo(ref  name, ref  age, ref mark);
            ShowResult(name, age, mark);

        }

        private static void ShowResult(string name, int age, float mark)
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Mark:" + mark);


        }

        private static void GetUserInfo(ref string name, ref int age, ref float mark)
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();

            Console.WriteLine("Nhap tuoi cua ban:");
            age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhap diem cua ban:");
            //mark = Convert.ToSingle(Console.ReadLine());
        }
    }
}
