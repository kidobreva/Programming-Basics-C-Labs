using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;
            var oddMin = 1000000000.0;
            var oddMax = -1000000000.0;
            var evenMin = 1000000000.0;
            var evenMax = -1000000000.0;

            if (n != 0 && n != 1)
            {
                for (var i = 1; i <= n; i++)
                {
                    var num = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + num;
                        if (num > evenMax)
                            evenMax = num;
                        if (num < evenMin)
                            evenMin = num;                       
                    }

                    else if (i % 2 != 0)
                    {
                        oddSum = oddSum + num;
                        if (num > oddMax)
                            oddMax = num;
                        if (num < oddMin)
                            oddMin = num;
                    }

                }

                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            
            else if (n == 1)
            {
                var num = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0},", num);
                Console.WriteLine("OddMin={0},", num);
                Console.WriteLine("OddMax={0},", num);
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }

            else if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }

        }
    }
}
