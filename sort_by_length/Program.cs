using System;

namespace sort_by_length
{

    //sort array elements by length
    // output second by length
    class Program
    {

        int number;
        static string[] myArray;
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

        public static void SortByLength(string[] myArray)
        {
            
            string temp;
            Console.WriteLine("Sorted array ASC");
            
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i].Length > myArray[j].Length)
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
                
                Console.WriteLine(myArray[i]);
                

            }

            Console.WriteLine($"Second by length = {myArray[myArray.Length-2]}");
            
        }
        static void Main(string[] args)
        {
            SortByLength(FillArray());

            Console.ReadLine();
        }
    }
}

