using System;

namespace first_by_length
{
    //find the longest element
    class Program
    {

        int number;
        static string[] myArray;
        public static string[] FillArray()
        {

            /*   Console.WriteLine("MyArray:");
   string [] myArray = { "Orange", "Blue", "Red", "Yellow", "Black" };*/
   

            Console.Write("Enter number of elements\t");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] myArray = new string[number];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter element {i}\t");
                myArray[i] = Console.ReadLine();
            }

            Console.WriteLine("My array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine();
            return myArray;

        }

        public static void GetLength(string[] myArray)
        {
            int maxLength = 0;
            string maxElement = "unknown";

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Length of element [ {i} ]\t");
                Console.WriteLine(myArray[i].Length);
                if (myArray[i].Length > maxLength)
                {
                    maxLength = myArray[i].Length;
                    maxElement = myArray[i];
                }
                    
            }
            Console.WriteLine($"Max length element= {maxElement} with length {maxLength} ");
        }
        static void Main(string[] args)
        {
            GetLength(FillArray());
                              
            Console.ReadLine();
        }
    }
}
