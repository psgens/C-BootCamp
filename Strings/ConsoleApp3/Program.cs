using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Patrick"; //S in string must be lowercase.

            string message = "My name is " + myname;

            string capmessage = message.ToUpper();

            Console.WriteLine("My name is " + myname);
            Console.WriteLine(capmessage);
            Console.Read();
        }
    }
}
