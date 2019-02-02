using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Constants ar immutable values which are known
    //at compile time and do not change for the life of the program
    class Program
    {
        //constants as fields
        const double pi = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "10.14.1988";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is {0}" , birthday);
            Console.Read();
       
        }
    }
}
