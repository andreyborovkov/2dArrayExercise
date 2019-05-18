using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const int row = 4;
            const int column = 2;
            int[,] array = new int[row, column] { { 120, 6 }, { 1, 6 }, { 7, 6 }, { 1, 6 } };
            int[] sum = new int[column];

            for (int c = 0; c < column; c++)
            {
                for (int r = 0; r < row ; r++)
                {
                    sum[c] += array[r, c];
                }
                Console.WriteLine("sum: " + sum[c]);
            }

            int min = sum[0];
            int minColumn = 0;

            for (int i = 1; i < sum.Length; i++)
            {
                if (min > sum[i])
                {
                    min = sum[i];
                    minColumn = i;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, minColumn] = -1;
            }

            Console.WriteLine("MinColumn Index: " + minColumn);



            //Display the array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
