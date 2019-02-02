using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_2
{
    class Boss:Employee
    {
        public string Companycar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary):base(name,firstName,salary)
        {
            this.Companycar = companyCar;
        }


        public void Lead()
        {
            Console.WriteLine("I'm a leader! My name is {0}! I drive a {1}", FirstName, Companycar);
        }



    }
}
