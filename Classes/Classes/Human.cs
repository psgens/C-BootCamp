using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Human
    {
        //member variable
        public string FirstName;
        public string LastName;

        //member method
        public void Introduction()
        {
            Console.WriteLine("Hi, I'm {0} {1}",  FirstName , LastName);
        }
    }
}
