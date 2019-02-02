using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString; //will not give you addition

            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.Read();
        
        }
    }
}
