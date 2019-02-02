using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Human
    {
        //member variable
        public string FirstName;
        private string LastName;
        private string EyeColor;
        private int Age;


        //Default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created!");
        }

        //Parameterized Constructor
        public Human(string myFirstName, string LastName, string EyeColor, int Age)
        {

            FirstName = myFirstName;
            this.LastName = LastName;
            this.EyeColor = EyeColor;
            this.Age = Age;

        }

        public Human(string myFirstName, string LastName, string EyeColor)
        {
            FirstName = myFirstName;
            this.LastName = LastName;
            this.EyeColor = EyeColor;
        }

        public Human(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public Human(string FirstName)
        {
            this.FirstName = FirstName;
        }


        public void Introduction()
        {
            if (Age != 0 && EyeColor != null &&  LastName != null && FirstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", FirstName, LastName);
                Console.WriteLine("I'm {0} and I have {1} color eyes", Age, EyeColor);
            }
            else if (Age < 2 && Age > 0)
            {
                Console.WriteLine("Googoo Gahgah!");
            }
            else if (LastName != null && FirstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", FirstName, LastName);
            }
            else if (LastName != null)
            {
                Console.WriteLine("Hi, I'm {0}", FirstName);
            }
            else if (EyeColor != null && LastName != null && FirstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", FirstName, LastName);
                Console.WriteLine("I have {0} color eyes", EyeColor);
            }
        }
    }
}
