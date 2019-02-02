using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //Pre increment
            Console.WriteLine("num is {0}", ++num);


            //decrement opperator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //Pre idecrement
            Console.WriteLine("num is {0}", --num);

            //
            int result;
            result = num1 + num2;
            Console.WriteLine("num1 + num2 {0}", result);
            result = num1 - num2;
            Console.WriteLine("num1 - num2 {0}", result);
            result = num1 / num2;
            Console.WriteLine("num1 / num2 {0}", result);
            result = num1 * num2;
            Console.WriteLine("num1 * num2 {0}", result);
            result = num1 % num2;
            Console.WriteLine("num1 % num2 {0}", result); //Returns the remainder.


            //Relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 > num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            bool isNotEqual;
            isNotEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isNotEqual);


            //Conditional Operators
            bool isLowerandSunny;
            isLowerandSunny = isLower && isSunny;
            Console.WriteLine("The result of isLower and isSunny is {0}", isLowerandSunny);

            isLowerandSunny = isLower || isSunny;
            Console.WriteLine("The result of isLower || isSunny is {0}", isLowerandSunny);




            Console.ReadKey();

        }
    }
}
