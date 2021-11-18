using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class MultiDimensionArray
    {
        static void Main()
        {
            // mang 2 chieu 
            // mang vuong 
            int[,] matrix = new int[10,8];
            bool[,] cons = new bool[10,10];
            //Su dung 
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            //Console.WriteLine($"Row: {row} , Col {col}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine();
            }
            // mang zigzag
            int[][] matrix2 = new int[10][];
            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = new int[1+i];
            }
            //Sử dung 
            int row1 = matrix2.Length;// So hang
            int ColOfRow0 = matrix2[0].Length;// so cot cua hang thu 1
            Console.WriteLine("=================================");
            //Console.WriteLine($"Row: {row1} , Col {ColOfRow0}");
            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    Console.Write(matrix2[i][j] + " ");
                }

                Console.WriteLine();
            }
            float[][] floats;
        }
    }
}
