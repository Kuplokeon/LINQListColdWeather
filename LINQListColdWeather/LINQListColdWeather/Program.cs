using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQListColdWeather
{
    enum DayOfWeek { Sun = 0, Mon = 1, Tue, Wed, Thu, Fri, Sat };

    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> daysForcasted = new List<Weather> {
            new Weather (DayOfWeek.Tue, 35, 28),
            new Weather (DayOfWeek.Wed, 35, 28),
            new Weather (DayOfWeek.Thu, 35, 26),
            new Weather (DayOfWeek.Fri, 37, 29),
            new Weather (DayOfWeek.Sat, 41, 33),
        };
            var coldDays =
                from i in daysForcasted
                where i.HighTemp < 40
                orderby i.Day
                select i;

            foreach (Weather i in coldDays)
            {
                Console.WriteLine("Cold weather on " + i.Day);
            }
        }
    }

    class Weather
    {
        public DayOfWeek Day { set; get; }
        public int HighTemp { set; get; }
        public int LowTemp { set; get; }

        public Weather(DayOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }

    }
}
