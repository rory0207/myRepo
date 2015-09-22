using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[,] arrayA = new int[5,5] { { 0, 2, 0, 0, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 1 }, { 0, 1, 1, 0, 0 } };

            int[,] matrixA = new int[2, 3] { { 1, 1 ,2}, { 1, 2, 1 }};

            int[,] matrixB = new int[3, 2] { { 3, 1 }, { 1, 2 }, { 3, 1 } };

            //int[,] arrayA = new int[3, 2] { { 2,4}, { 3,2} , { 0,1} };


            for (int i=0; i< matrixA.GetLength(0); i++)
            {

                for (int j=0;j< matrixA.GetLength(1); j++)
                {
                    //Console.Write("matrixA[{0},{1}]: {2}  ", i, j, matrixA[i, j]);

                    Console.Write("{0}  ", matrixA[i, j]);

                    //Console.Write("j+1 = {0} % matrixA.GetLength(1) = {1} = {2}", j + 1, matrixA.GetLength(1), (j + 1) % matrixA.GetLength(1) );
                    
                    if ((j+1) % matrixA.GetLength(1) == 0)
                    {
                        // Redefine the newline characters to double space.
                        Console.Write("\r\n\r\n");
                    }
                }                
            }



            //// show element 1
            //foreach (int row in arrayA)
            //{
            //    Console.WriteLine(row + ";");
            //}


            // show element 2
            //int count = 0;
            //foreach (int element in matrixA)
            //{
            //    count += 1;

            //    // Console.Write("#{0}:{1} ", ("00"+ count).PadRight(2), ("00"+element).PadRight(2));
            //    Console.Write("{0} ", ("0" + element).PadRight(2));



            //    if (count % matrixA.GetLength(1) == 0)
            //    {
            //        // Redefine the newline characters to double space.
            //        Console.Write("\r\n\r\n");
            //    }
            //}

            //Console.Write("\r\n\r\n");
            //Console.WriteLine("Number of elements in the array: {0}", count);





            Console.ReadLine();


        }
    }
}
