using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontSurface box = new FrontSurface();
            Console.WriteLine("Front Surface of the box is {0}", box.frontsurface);
            Console.Read();
        }
    }
}
