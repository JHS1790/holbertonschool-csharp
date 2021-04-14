using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = 0;
            array[2, 2] = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0}{1}", array[i, j], j == array.GetLength(1) - 1 ? "":" ");
                Console.Write("\n");
            }
        }
    }
}
