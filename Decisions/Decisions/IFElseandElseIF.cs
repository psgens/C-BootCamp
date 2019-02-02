using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseandElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");

            string numtemp = Console.ReadLine();
            int temperature;
            int number;

            if (int.TryParse(numtemp, out number))
            {
                temperature = number;
            }

            else
            {
                temperature = 0;
                Console.WriteLine("Value set as no number Temperature set as 0");
            }


            if (temperature < 10)

            {
                Console.WriteLine("Take the coat.");

            }
            else if (temperature == 10)
            {
                Console.WriteLine("It's 10 degrees C.");
            }

            else if (temperature > 10)
            {
                Console.WriteLine("It's cozy and warm.");
            }

            Console.Read();
        
        }
    }
}
