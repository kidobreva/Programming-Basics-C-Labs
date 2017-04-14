using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 0;
            var num1 = 0;                        
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > num1)
                {

                    number = number + 1;
                }
                else
                    number = 1;

                if (number > sum)
                {
                    sum = number;
                }
                num1 = num;
            }
            
            Console.WriteLine(sum);
        }
    }
}
