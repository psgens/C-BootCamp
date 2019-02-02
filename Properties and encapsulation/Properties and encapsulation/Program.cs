using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            box Box = new box(5,4,10);
            Console.WriteLine("The volume is {0}", Box.Volume);

            Box.DisplayInfo();
            Console.Read();
        }
    }
}
