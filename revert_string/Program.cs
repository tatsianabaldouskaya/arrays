using System;

namespace revert_string
{
    //revert strings in array
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


        public static void RevertString(string[] myArray)
        {
            
            Console.WriteLine("Array with reverted strings");
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = myArray[i].Length - 1; j >= 0; j--)
                {
                     
                    Console.Write((myArray[i])[j]);
                }
                Console.WriteLine();
            }

            
        }


        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter something");
            var str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }*/

            RevertString(FillArray());
            Console.ReadLine();

        }
    }
    
}
