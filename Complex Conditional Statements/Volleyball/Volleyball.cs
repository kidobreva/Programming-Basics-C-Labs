using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsInBirthtown = int.Parse(Console.ReadLine());

            var weekendsInYear = 48;
            var playsInSofia = ((weekendsInYear - weekendsInBirthtown) * 3) / 4.0;
            var playsOnHolidays = (holidays * 2) / 3.0;
            var plays = playsInSofia + weekendsInBirthtown + playsOnHolidays;

            if (year == "leap")
            {
                var playsLeap = Math.Floor((0.15 * plays) + plays);
                Console.WriteLine(playsLeap);
            }
            else if (year == "normal")
                Console.WriteLine(Math.Floor(plays));
        }
    }
}
