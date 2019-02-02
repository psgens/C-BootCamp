using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Patrick = new Human("Patrick", "Gens", "Brown", 29);
            Patrick.Introduction();


            Human Cassie = new Human("Cassie", "Perrault", "Blue", 25);
            Cassie.Introduction();

            Human Bethany = new Human("Beth", "Phillips", "Brown", 1);
            Bethany.Introduction();

            Human Madlyn = new Human("Maddy", "Smith", "Brown");
            Madlyn.Introduction();

            Human Tim = new Human("Tim", "Smith");
            Tim.Introduction();

            Human Charles = new Human("Charles");
            Charles.Introduction();

            Human BasicHuman = new Human();
            BasicHuman.Introduction();

            Console.Read();
        }
    }
}
