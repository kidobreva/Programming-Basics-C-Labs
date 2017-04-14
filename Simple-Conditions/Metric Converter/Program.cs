using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToLower();
            var output = Console.ReadLine().ToLower();

            //var mm = 1000.00;
            //var cm = 100.00;
            //var mi = 0.000621371192;
            //var inn = 39.3700787;
            //var km = 0.001;
            //var ft = 3.2808399;
            //var yd = 1.0936133;

            if (input == "mm")
            { num = num / 1000.00; }
            if (input == "cm")
            { num = num / 100.00; }
            if (input == "mi")
            { num = num / 0.000621371192; }
            if (input == "in")
            { num = num / 39.3700787; }
            if (input == "km")
            { num = num / 0.001; }
            if (input == "ft")
            { num = num / 3.2808399; }
            if (input == "yd")
            { num = num / 1.0936133; }

            if (output == "mm")
            { num = num * 1000.00; }
            if (output == "cm")
            { num = num * 100.00; }
            if (output == "mi")
            { num = num * 0.000621371192; }
            if (output == "in")
            { num = num * 39.3700787; }
            if (output == "km")
            { num = num * 0.001; }
            if (output == "ft")
            { num = num * 3.2808399; }
            if (output == "yd")
            { num = num * 1.0936133; }

            Console.WriteLine(num + " " + output);

        }
    }
}
