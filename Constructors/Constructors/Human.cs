using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Human
    {
        //member variable
        public string FirstName;
        private string LastName;
        private string EyeColor;
        private int Age;

        //Constructor
        public Human(string myFirstName, string LastName, string EyeColor, int Age)
        {
            //variable has to be public
            FirstName = myFirstName;
            //or using this 
            //this variable can be private
            this.LastName = LastName;
            this.EyeColor = EyeColor;
            this.Age = Age;

        }

        //member method
        public void Introduction()
        {
            if (Age < 2)
            {
                Console.WriteLine("Googoo Gahgah!");
            }
            else
            {
                Console.WriteLine("Hi, I'm {0} {1}", FirstName, LastName);
                Console.WriteLine("I'm {0} and I have {1} color eyes", Age, EyeColor);
            }
        }
    }
}
