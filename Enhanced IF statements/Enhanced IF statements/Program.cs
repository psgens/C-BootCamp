using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_IF_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //condition ? FirstExpression : SecondExpression;
            //condition has to be either true or false
            //The conditional operator is right - associative.
            //The expression a ? b: c ? d : e
            //is evaluated as a ? b: (c ? d: e).
            //not as (a ? b : c) ? d : e.
            //The conditional operator cannot be overloaded,

            int temperature = -5;
            string stateofmatter;

            /*
            if (temperature < 0)
            {
                stateofmatter = "solid";
            }
            else
            {
                stateofmatter = "liquid";
            }
            */


            //in short.

            stateofmatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("state of matter is "+ stateofmatter );

            temperature += 30;

            stateofmatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("state of matter is " + stateofmatter);

            temperature += 80;

            stateofmatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";

            Console.WriteLine("state of matter is " + stateofmatter);

            Console.Read();

        }
    }
}
