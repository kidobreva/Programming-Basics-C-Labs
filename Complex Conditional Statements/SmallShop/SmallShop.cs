﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                { Console.WriteLine(0.5 * quantity); }
                else if (product == "water")
                    Console.WriteLine(0.8 * quantity);
                else if (product == "beer")
                    Console.WriteLine(1.20 * quantity);
                else if (product == "sweets")
                    Console.WriteLine(1.45 * quantity);
                else if (product == "peanuts")
                    Console.WriteLine(1.60 * quantity);
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(0.40 * quantity);
                else if (product == "water")
                    Console.WriteLine(0.70 * quantity);
                else if (product == "beer")
                    Console.WriteLine(1.15 * quantity);
                else if (product == "sweets")
                    Console.WriteLine(1.30 * quantity);
                else if (product == "peanuts")
                    Console.WriteLine(1.50 * quantity);
            }
            else if (town == "varna")
                {
                if (product == "coffee")
                    Console.WriteLine(0.45 * quantity);
                else if (product == "water")
                    Console.WriteLine(0.70 * quantity);
                else if (product == "beer")
                    Console.WriteLine(1.10 * quantity);
                else if (product == "sweets")
                    Console.WriteLine(1.35 * quantity);
                else if (product == "peanuts")
                    Console.WriteLine(1.55 * quantity);
            }
        }
    }
}
