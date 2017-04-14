using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var secs = sec1 + sec2 + sec3;
            var mins = 0;
              
            if (secs <= 59)
            {secs = sec1 + sec2 +sec3; }
            if (secs >=60 && secs <= 119)
            { mins++; secs = secs - 60; }
            if (secs >= 120 && secs <= 179)
            { mins++; mins++; secs = secs - 120; }

            if (secs < 10)
            { Console.WriteLine(mins + ":" + "0" + secs); }

            else
            { Console.WriteLine(mins + ":" + secs); }

        }
    }
}
