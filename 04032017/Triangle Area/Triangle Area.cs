using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            var a = Math.Max(x2, x3) - Math.Min(x2, x3);
            var ha = Math.Max(y1, y3) - Math.Min(y1, y3);
            var s = ((a * ha) / 2.0);
            Console.WriteLine(s);
        }
    }
}
