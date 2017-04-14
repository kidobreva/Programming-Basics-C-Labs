using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            //DateTime months = new DateTime(month);
            //DateTime days = new DateTime(day);
            
            DateTime date = new DateTime(2017, month, day);
            date = date.AddDays(5);

            Console.WriteLine("{0}.{1:D2}", date.Day, date.Month);
      

     

    }
    }
}
