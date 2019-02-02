using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            int totalscore = 0;
            int i=1;
            do
            {
                Console.WriteLine("What was sudent number " + i + "'s score?");
                string Inscore = Console.ReadLine();
                bool IsNum = Int32.TryParse(Inscore, out score);
                if (IsNum)
                {
                    if (0 <= score && score <= 20)
                    {
                        totalscore += score;
                        i++;
                    }
                    else if (score == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That score wasn't right");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a number!");
                    continue;
                }
            } while (score != -1);

            i--;
            double average = (double) totalscore / (double) i;

            Console.WriteLine("The average score for the " + i + " students is : " + average);

            Console.Read();
        }
    }
}
