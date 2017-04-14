using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var x1 = 0;
            var x2 = 3 * h;
            var y1 = 0;
            var y2 = h;
            var x3 = h;
            var x4 = 2 * h;
            var y3 = h;
            var y4 = 4 * h;

            if (x < 0 || y < 0)
                Console.WriteLine("Outside");
            else if (x > x2)
                Console.WriteLine("Outside");
            else if (y > y4)
                Console.WriteLine("Outside");
            else if (x > h && x < 2 * h && (y == y2 || y == y3))
                Console.WriteLine("Inside");
            else if (x > h && x < 2 * h && y == y4)
                Console.WriteLine("Border");
            else if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
                Console.WriteLine("Border");
            else if ((x == x3 || x == x4) && (y >= y3 && y <= y4))
                Console.WriteLine("Border");
            else if ((y == y1 || y == y2) && (x >= x1 || x <= x2))
                Console.WriteLine("Border");
            else if ((y == y3 && y == y4) && (x >= x1 && x <= x2))
                Console.WriteLine("Border");
            else if ((x > x1 && x < x2) && (y > y1 && y < y2))
                Console.WriteLine("Inside");
            else if ((x > x3 && x < x4) && (y > y3 && y < y4))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Outside");

        }
    }
}
