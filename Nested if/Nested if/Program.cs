using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your UserName!");
            bool IsAdmin = false;
            bool IsRegistered = true;
            string UserName = Console.ReadLine();

            if (IsRegistered)
            {
                Console.WriteLine("Hi registered user");
                if (UserName != "")
                {
                    Console.WriteLine("Hello " + UserName);
                    if (IsAdmin || UserName.Equals("Admin"))
                    {
                        Console.WriteLine("Hello, Admin " + UserName);
                    }
                }
            }
            Console.Read();

        }
    }
}
