using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
               
            }

            Console.WriteLine("Count by 5");
            for(int i = 0; i <= 50; i +=5)
                {
                    Console.WriteLine(i);

                }
            Console.WriteLine("Only odds until 20");
            for(int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
