using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee cassie = new Employee("Cassie", "Gens", 28000);

            cassie.Work();
            cassie.Pause();

            Boss dude = new Boss("Tesla", "Man", "Boss", 90000);

            dude.Lead();

            Trainee newGuy = new Trainee(32, 10, "Gens", "Seb", 10000);

            newGuy.Learn();
            newGuy.Work();


            Console.ReadKey();

        }
    }
}
