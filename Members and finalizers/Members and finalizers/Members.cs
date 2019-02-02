using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_and_finalizers
{
    class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;


        //member - property
        public string JobTitle
        { get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
         }

        //public member method
        public void Introduction(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1} I'm {2} years old.", memberName, jobTitle,age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member Constructor
        public Members()
        {
            age = 25;
            memberName = "Cassie";
            salary = 25000;
            jobTitle = "ROI";

            Console.WriteLine("Object created");
        }

        //member - Finalizer / Destructor
        ~Members()
        {
            //cleaning up statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Deconstruction of Members object");

        }
    }
}
