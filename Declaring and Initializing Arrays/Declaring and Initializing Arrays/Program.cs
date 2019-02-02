using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaring_and_Initializing_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 10;
            grades[3] = 12;
            grades[4] = 19;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            int[] gradesofMathStudentsA = {13, 11, 12, 8, 7};

            int[] gradesofMathStudentsB = new int[] { 15, 3, 17 };

            Console.WriteLine("Grades length of gradesofMathStudentsA : {0}", gradesofMathStudentsA.Length);

            Console.ReadKey();

        }
    }
}
