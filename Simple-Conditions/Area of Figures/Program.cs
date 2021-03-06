﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var squareArea = a * a;
                Console.WriteLine(Math.Round(squareArea, 3));
            }

            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var rectangleArea = a * b;
                Console.WriteLine(Math.Round(rectangleArea, 3));
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * r * r;
                Console.WriteLine(Math.Round(circleArea, 3));
            }

            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var ha = double.Parse(Console.ReadLine());
                var triangleArea = (a * ha)/2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }
        }
    }
}
