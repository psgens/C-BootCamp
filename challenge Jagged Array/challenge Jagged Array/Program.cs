using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a jagged array, which contains 3 "friends arrays", in which two family members should be stored.
            //Introduce faamily members from different families to each other via console.


            string[][] friendsAndFamily = new string[][]
                {
                    new string []{"Michael","Kayla"},
                    new string []{ "Cassie", "Patrick"},
                    new string []{ "Mark", "Sam"}
                };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[0][0], friendsAndFamily[1][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[1][1], friendsAndFamily[2][1]);
            Console.ReadKey();

        }
    }
}
