using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3_solve
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your User Name");
            username = Console.ReadLine();
            Console.WriteLine("Please enter a Password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed!");
            Console.WriteLine("----------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter User Name");
            if (username == Console.ReadLine())
                {
                Console.WriteLine("Please enter your Password");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine("You are logged in!");
                        Console.WriteLine("Hello, " + username);
                    }
                    
                    else
                    {
                    Console.WriteLine("That Password is incorrect!");
                    Console.WriteLine("Goodbye!");
                    }
                }
            else
            {
                Console.WriteLine("You are not a registered User");
                Console.WriteLine("Please Register.");
            }
            }
        }
    }
}
