﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*" + new string('/', (2 * n - 2)) + "*");
                if (i == (n - 1) / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));
                Console.Write("*" + new string('/', (2 * n - 2)) + "*");
                Console.WriteLine();
            }
            // Print the bottom part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
