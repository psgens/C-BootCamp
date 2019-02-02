using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int lengthoftext = 0;
            string allfriends = "";

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            i = 15;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            do
            {
                Console.WriteLine("Please enter the name of a friend: ");
                string nameoffriend = Console.ReadLine();
                int currentlength = nameoffriend.Length;
                lengthoftext += currentlength;
                allfriends += nameoffriend;
            }
            while (lengthoftext < 20);
            Console.WriteLine("Thanks, that was enough! All of your friends are: " + allfriends);



            Console.Read();

        }
    }
}
