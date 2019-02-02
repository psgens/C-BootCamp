using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Cassie";
            string friend2 = "Kayla";
            string friend3 = "Mark";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();        }

        public static void GreetFriend(string Person1)
        {
            Console.WriteLine("Hi " + Person1 + ", my friend!");
        }
    }
}
