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
            //Implicit conversion
            int num = 1239067;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            //Explicit Conversion
            //Cast double to int;
            myInt = (int)myDouble;

            //Type conversion
            string myString = myDouble.ToString();
            string myNumString = num.ToString();
            string myFloatString = myFloat.ToString();

            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}
