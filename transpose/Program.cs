using System;

namespace revert_array
{
    //revert array of given length that is filled by user
    class Program
    {
        int number;
        string[] myArray;
        public static string[] FillArray()
        {
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
        

        public static void Revert(string[] myArray)
        {
            ;
            Console.WriteLine("Reverted array");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }


        static void Main(string[] args)
        {

            Revert(FillArray());
            
            Console.ReadLine();
        }
    }
}
