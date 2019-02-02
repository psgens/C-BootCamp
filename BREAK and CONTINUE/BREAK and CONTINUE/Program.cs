using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREAK_and_CONTINUE
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We skip 3.");
                    continue;                
                }
                else if (i==7)
                {
                    Console.WriteLine("We stop at 7!");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
