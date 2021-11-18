using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ParamsModifier
    {
        static void Main()
        {
            // Params Modifier
            float[] marks = {8, 9, 10, 8.5f, 9.5f};
            float math = 9;
            float bio = 8.5f;
            float vi = 9;
            float it = 10;

            float avg = Avg(9,8,9,10,it);
            Console.WriteLine(avg);
        }

        static float Avg(params float[] marks)
        {
            float sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }

            return (marks.Length == 0) ? 0 : sum / marks.Length;
        }
    }
}
