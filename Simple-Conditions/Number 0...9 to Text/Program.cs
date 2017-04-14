using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //var salary = 1001;
            //var bonus = 0;
            //if (salary > 1000)
            //{
            //    bonus = 100;
            //    salary = salary + bonus;
            //    Console.WriteLine(salary);
            //}
            //Console.WriteLine(salary + " " + bonus);

            var num = int.Parse(Console.ReadLine());

            if (num == 0)
            Console.WriteLine("null");
            if (num == 1)
            Console.WriteLine("one");
            if (num == 2)
            Console.WriteLine("two");
            if (num == 3)
            Console.WriteLine("three");
            if (num == 4)
            Console.WriteLine("four");
            if (num == 5)
            Console.WriteLine("five");
            if (num == 6)
            {
                Console.WriteLine("six");
            }
            else if (num == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num == 9)
            {
                Console.WriteLine("nine");
            }
            
            else if (num > 9)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
