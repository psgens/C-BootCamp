using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for(int j =0; j < nums.Length ; j++)
            {
                Console.WriteLine("Element{0} = {1}", j , nums[j]);
            }

            int count = 0;
            
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", count, k);
                count++;
            }


            string[] friend = { "Cassie", "Mark", "Kayla", "Michael", "Sam" };

            foreach(string name in friend)
            {
                Console.WriteLine("Hello, {0}", name);
            }

            Console.ReadKey();
        }
    }
}
