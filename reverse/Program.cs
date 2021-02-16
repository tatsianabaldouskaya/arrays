using System;

namespace transpose
{
    class Program
    {
        //Fill matrix with random numbers and transpose it

        static void Main(string[] args)
        {
            //Matrix m = new Matrix();
            // m.GetTransposedMatrix();
            Matrix.GetLength();
            Matrix.GetTransposedMatrix(Matrix.ComposeInitialMatrix());
            
            



            Console.ReadLine();
        }
    }
}

