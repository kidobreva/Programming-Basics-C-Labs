﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - 3 >= a)
            {
                for (int n1 = a; n1 <= b - 3; n1++)
                {
                    for (int n2 = n1 + 1; n2 <= b - 2; n2++)
                    {
                        for (int n3 = n2 + 1; n3 <= b - 1; n3++)
                        {
                            for (int n4 = n3 + 1; n4 <= b; n4++)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("No");
        }
    }
}
