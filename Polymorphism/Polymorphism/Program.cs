using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<car>
            {
                new Audi(200, "green", "A4"),
                new BMW(25, "silver", "M3")

            };

            foreach(var car in cars)
            {
                car.Repair();

            }

            car bmwZ3 = new BMW(200, "black", "Z3");
            car audiA3 = new Audi(100, "blue", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            car carB = (car)bmwM5;

            carB.ShowDetails();

            Console.ReadKey();

        }
    }
}
