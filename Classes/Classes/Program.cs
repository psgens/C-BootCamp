using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of a class.
            //
            Human Patrick = new Human();
            Patrick.FirstName = "Patrick";
            Patrick.Introduction();


            Human Cassie = new Human();
            Cassie.FirstName = "Cassie";
            Cassie.LastName = "Perrault";
            Cassie.Introduction();


            Console.Read();
        }
    }
}
