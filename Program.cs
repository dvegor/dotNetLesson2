using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            int[] temp = new int[a.GetLength(1) * a.GetLength(0)];
            int count = 0;
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    temp[count] = a[i, j];
                    count++;

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
               
            }
            Array.Sort(temp);
            count = 0;
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = temp[count];
                    count++;

                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }

        }


    }
}

