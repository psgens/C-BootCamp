using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an arraylist with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            //declaring an arraylist with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(22.37);
            myArrayList.Add(7);

            //delete elemet with specific value from the array list
            myArrayList.Remove(25);

            //delete element at a specific index
            myArrayList.RemoveAt(2);

            Console.WriteLine(myArrayList.Count);


            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
            




        }
    }
}
