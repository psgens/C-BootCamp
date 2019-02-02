using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate()); //Will give an error if the user enters anything but an integer.
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();


            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);



            Console.WriteLine("Those values added together are:");
            int result = num1 + num2;
            return result;

        }
    }
}
