using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
                Console.WriteLine("in");
            else
                Console.WriteLine("out");

           if (Math.Abs(first - point) > Math.Abs(second - point))
                Console.WriteLine("{0}", Math.Abs(second - point));
           else
                Console.WriteLine("{0}", Math.Abs(first - point));
        }
    }
}
