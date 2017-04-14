using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c && a <= b)
                Console.WriteLine("{0} + {1} = {2}", a, b, c);

            else if (b + a == c && b <= a)
                Console.WriteLine("{0} + {1} = {2}", b, a, c);

            else if (a + c == b && a <= c)
                Console.WriteLine("{0} + {1} = {2}", a, c, b);

            else if (c + a == b && c <= a)
                Console.WriteLine("{0} + {1} = {2}", c, a, b);

            else if (b + c == a && b <= c)
                Console.WriteLine("{0} + {1} = {2}", b, c, a);

            else if (c + b == a && c <= b)
                Console.WriteLine("{0} + {1} = {2}", c, b, a);

            else
                Console.WriteLine("No");
        }
    }
}
