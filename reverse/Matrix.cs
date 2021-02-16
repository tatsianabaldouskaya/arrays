using System;
using System.Collections.Generic;
using System.Text;

namespace transpose
{
    class Matrix
    {

        public static int x;
        public static int y;
        private static int[,] initial;

        public static void GetLength()
        {
            Console.Write("Enter number of rows:\t");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:\t");
            y = Convert.ToInt32(Console.ReadLine());
           
        }

        public static int[,] ComposeInitialMatrix()
        {
            Console.WriteLine("Initial matrix");
            int[,] initial = new int[x, y];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    initial[i, j] = random.Next(1, 20);
                    Console.Write(initial[i, j] + "\t");
                    
                }
                Console.WriteLine();
                

            }
            return initial;
                    
            
        }

        public static void GetTransposedMatrix(int[,] initial)
        {
            int[,] transposed = new int[y, x];
            Console.WriteLine("Transposed matrix");
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    transposed[i, j] = initial[j, i];
                    Console.Write(transposed[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
