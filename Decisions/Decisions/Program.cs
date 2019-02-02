using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");

            string numtemp = Console.ReadLine();
            int temperature = int.Parse(numtemp);

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
