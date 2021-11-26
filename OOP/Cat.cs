using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Cat
    {
        public string petName;
        public int age;
        public float weight;
        public string color;

        public Cat()
        {
            petName = "Tom";
            age = 4;
            weight = 5.0f;
            color = "Black";

        }

        public void Sleep()
        {
            Console.WriteLine(petName + "is Sleeping");
        }

        public void Eat()
        {
            Console.WriteLine(petName + "eating fish meo meo");
        }

        public void Move()
        {
            Console.WriteLine("I'm running on the ground");
        }
          
    }
}
