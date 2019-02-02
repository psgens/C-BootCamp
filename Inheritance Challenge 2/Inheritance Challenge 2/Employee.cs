using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Employee
    {

        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "Gens";
            FirstName = "Patrick";
            Salary = 32000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }


        public void Work()
        {
            Console.WriteLine("I'm working!");
        }

        public void Pause()
        {
            Console.WriteLine("I'm taking a break.");
        }


    }
}
