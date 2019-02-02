using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try__Catch__Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("That is not number! Please try again.");

            }
            catch(OverflowException)
            {
                Console.WriteLine("Too few or too many numbers for an INT32!");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("You have to type something for this to work.");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception!");

            }
            finally
            {
                Console.WriteLine("This is called no matter what!");
            }
            

            Console.ReadKey();



        }
    }
}
