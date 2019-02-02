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
            byte mybyte = 1;
            Console.WriteLine(mybyte);
            sbyte mySbyte = -2;
            Console.WriteLine(mySbyte);
            int myInt = -23467;
            Console.WriteLine(myInt);
            uint myUint = 544444;
            Console.WriteLine(myUint);
            short myShort = -23;
            Console.WriteLine(myShort);
            ushort myUshort = 23;
            Console.WriteLine(myUshort);
            long myLong = -698709;
            Console.WriteLine(myLong);
            ulong myUlong = 9879;
            Console.WriteLine(myUlong);
            float myFloat = -8.9f;
            Console.WriteLine(myFloat);
            double myDouble = -0.9;
            Console.WriteLine(myDouble);
            char myChar = 'a';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myString = "I control text";
            Console.WriteLine(myString);
            string numText = "42";

            int myNumText = int.Parse(numText);
            Console.WriteLine(myNumText);
            Console.Read();
            
              
        }
    }
}
