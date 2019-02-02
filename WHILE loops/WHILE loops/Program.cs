using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Current count is {0}", i);
                Console.WriteLine("Please press enter");
                Console.ReadLine();
                i++;
            }




            Console.Read();
        }
    }
}
