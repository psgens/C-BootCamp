using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you registered?");
            string registered = Console.ReadLine();


            
            if (registered.Equals("no"))
            {
                Console.WriteLine("Please register");
                Console.WriteLine("What's your User Name?");
                string RegUserName = Console.ReadLine();

                Console.WriteLine("Please enter your UserName!");
                bool IsAdmin = false;
                string UserName = Console.ReadLine();

                if (UserName == RegUserName || UserName.Equals("Admin") || UserName.Equals("admin"))
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
                else
                {
                    Console.WriteLine("You are not registered! Please register");

                }
            }

            else
            {
                Console.WriteLine("Please enter your UserName!");
                bool IsAdmin = false;
                bool IsRegistered = false;
                string UserName = Console.ReadLine();

                if (IsRegistered)
                {
                    Console.WriteLine("Hi registered user");
                    if (UserName != "")
                    {
                        Console.WriteLine("Hello " + UserName);
                        if (IsAdmin || UserName.Equals("Admin") ||UserName.Equals("admin"))
                        {
                            Console.WriteLine("Hello, Admin " + UserName);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Register");

                }
            }
            Console.Read();


        }
    }
}
