using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_1._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[] a = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] b = new string[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] c = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] d = new string[] { "hundred" };

            int check1 = (n / 10) % 10;
            int check2 = (n % 10);

            if (n >= 0 && n <= 100)
            {
                if (n >= 0 && n < 10)
                {
                  if (n == 0)
                    {
                        Console.WriteLine("zero");
                    }

                    else
                    {
                       string one = a[n - 1];
                       Console.WriteLine(one);
                    }
                }


                else if (n >= 10 && n < 20)
                   {
                      if (n == 10)
                         {
                            string ten = a[n - 1];
                            Console.WriteLine(ten);
                         }
                      else
                         {
                           int dig = n % 10;
                           string two = b[dig];
                           Console.WriteLine(two);
                         }
                   }


                else if (check1 != 0 && check2 == 0)
                        {
                           int digit = n / 10;
                           string three = c[digit];
                           Console.WriteLine(three);
                        }

                else if (n > 20 && n % 10 != 0)
                        {
                           int dig1 = n % 10;
                           int dig2 = n /= 10;
                           string four = c[dig2];
                           string five = a[dig1 - 1];
                           Console.WriteLine("{0} {1}", four, five);
                        }

                else if (n == 100)
                        {
                           int dig1 = n % 10;
                           int dig2 = n /= 100;
                           string seven = d[dig2 - 1];
                           string six = a[dig1];
                           Console.WriteLine("{0} {1}", six, seven);
                        }
               }


                           else { Console.WriteLine("invalid number"); }

        }
    }
}
