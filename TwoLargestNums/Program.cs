//Joshua Pickenpaugh
//July 28th, 2017
//Two Largest Nums

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLargestNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables:
            List<double> lstDoubles = new List<double>();
            double dblMaxNum = 0;
            double dblSecondMaxNum = 0;

            //User input:
            Console.WriteLine("Enter 10 numbers: ");

            //Loop to attain user input:
            for (int x = 0; x < 10; x++)
            {
                double dblNum = Convert.ToInt32(Console.ReadLine());
                lstDoubles.Add(dblNum);
            }

            //...space...
            Console.WriteLine();

            //Loop to display list:
            foreach (double num in lstDoubles)
            {
                Console.Write(num);
            }

            Console.WriteLine();

            //Gets max and second max nums:
            dblMaxNum = lstDoubles.Max();
            var varIndexOfMax = lstDoubles.IndexOf(lstDoubles.Max());
            lstDoubles.RemoveAt(varIndexOfMax);
            dblSecondMaxNum = lstDoubles.Max();
            lstDoubles.Add(dblMaxNum);

            //Displays:
            Console.WriteLine("Max and second max nums: {0}, {1}.", dblMaxNum, dblSecondMaxNum);

            //...space...
            Console.WriteLine();

            //Loop to display list, again:
            foreach (double num in lstDoubles)
            {
                Console.Write(num);
            }

            Console.ReadKey();

        }
    }
}
