using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 2d Array
            string[,] matrix;

            //matrix = { { "1", "2"},{ "3","4"} } returns an error!

            //3d Array
            int[,,] threeD = new int[,,]
            {
                {
                    {1,2},
                    {3,4}
                },
                {
                    {5,6},
                    {7,8}
                }
            };
            Console.WriteLine("The value is {0}", threeD[1, 0, 0]);

            //2D Arrays
            int[,] array2D = new int[,]
            {
                {1,2,3},  //row0
                {4,5,6},  //row1
                {7,8,9}  //row2
            };

            Console.WriteLine("get the value 7 : {0}", array2D[2,0]);

            string[,] array2DString = new string[,] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            array2DString[1, 1] = "Chicken";
            Console.WriteLine("four is now : {0}", array2DString[1, 1]);



            int dimensions = array2DString.Rank; //gives the number of dimensions of the array.

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The dimensions of array2DString is {0}", dimensions);

            Console.ReadKey();
        }
    }
}
