using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;

            for (var i = 0; i < n; i++)
            {
                //var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)                
                    evenSum = evenSum + int.Parse(Console.ReadLine());                                
                    
                else               
                    oddSum = oddSum + int.Parse(Console.ReadLine());                                                    
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
        
    }
}

        //drugo reshenie
        //var n = int.Parse(Console.ReadLine());
        //var oddSum = 0;
        //var evenSum = 0;
        //for (var i = 0; i<n; i++)
        //{
        //var element = int.Parse(Console.ReadLine());
        //if (i % 2 == 0) oddSum += element;
        //else evenSum += element;
        //}



