﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // Declare Jagged Array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //Alternative way
            int[][] jaggedArray2 = new int[][]
            {
            new int[] { 2, 3, 5, 7, 11 },
            new int[] { 1, 2, 3 },
            new int[] { 13, 21 }

            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for(int i = 0; i< jaggedArray2.Length;i++)
            {
                Console.WriteLine("Element at {0}", i);
                for(int j = 0; j<jaggedArray2[i].Length; j++)
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
            }

            Console.ReadKey();
        }
    }
}
