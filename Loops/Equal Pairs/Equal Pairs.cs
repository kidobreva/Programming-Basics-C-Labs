using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentSum = 0;
            var previousSum = 0;
            var currentDiff = 1;
            var maxDiff = 0;            

            for (int i = 1; i <= n; i++)
            {
                previousSum = currentSum;
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                currentSum = a + b;
                
                currentDiff = Math.Abs(currentSum - previousSum);
                if (currentDiff > maxDiff && i >= 2)
                {
                    maxDiff = currentDiff;
                }
            }
            if (maxDiff == 0)
                Console.WriteLine("Yes, value=" + currentSum);
            else
                Console.WriteLine("No, maxdiff=" + maxDiff);

        }
    }
}
