﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //Console.WriteLine(@"+{0}+", new string('-', n-2);
            //Console.WriteLine(@"{0}{1}{0}", new string('|', 1), new string('-', n-2));

            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
            Console.WriteLine(" +");

            for (int r = 0; r < n - 2; r++)
            {
                Console.Write("| ");
                var mid = n - 2;
                for (int col = 0; col < mid; col++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}
