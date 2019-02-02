using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Writesomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }


        //Access modifier (static) return type method name (parameter1, Parameter2)
        public static void Writesomething()
        {
            Console.WriteLine("I am called from a method");
            Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }
}
