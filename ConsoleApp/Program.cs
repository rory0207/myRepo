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

            int[,] arrayA = new int[5,5] { { 0, 2, 0, 0, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 1 }, { 0, 1, 1, 0, 0 } };

            //int[,] arrayA = new int[2, 3] { { 2, 3 ,3}, { 1, 5, 4 }};

            //int[,] arrayA = new int[3, 2] { { 2,4}, { 3,2} , { 0,1} };


            //// show element 1
            //foreach (int row in arrayA)
            //{
            //    Console.WriteLine(row + ";");
            //}


            // show element 3
            int count = 0;
            foreach (int element in arrayA)
            {
                count += 1;
                
                Console.Write("#{0}:{1} ", count, element);

                if (count % arrayA.GetLength(1) == 0)
                {
                    // Redefine the newline characters to double space.
                    Console.Write("\r\n\r\n");
                }
            }

            Console.Write("\r\n\r\n");
            Console.WriteLine("Number of elements in the array: {0}", count);

            Console.ReadLine();


        }
    }
}
