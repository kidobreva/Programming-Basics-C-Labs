using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxElement = 0;
            
            for (var i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                sum = sum + element;
                if (element > maxElement)
                    maxElement = element;                           
            }
            if (maxElement == (sum - maxElement))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxElement);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(maxElement - (sum - maxElement)));
            }
                

            //Console.WriteLine(sum);
            //Console.WriteLine(maxElement);
        }
    }
}
