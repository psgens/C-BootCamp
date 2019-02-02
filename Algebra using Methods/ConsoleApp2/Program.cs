using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 6));

            Console.WriteLine(Mult(3, 4));

            Console.WriteLine(Divide(28, 7));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Mult(int num3, int num4)
        {
            return num3 * num4;

        }

        public static double Divide(double num5, double num6)
        {
            return num5/num6;
        }
    }
}
