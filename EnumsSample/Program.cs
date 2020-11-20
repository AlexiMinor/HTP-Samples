using System;

namespace EnumsSample
{
    class Program
    {
        static void Main(string[] args)
        {
           var dayOfYear = new DayOfTheYear()
           {
               Number = 15,
               Month = Months.August
           };

           var dayOfYear2 = new DayOfTheYear()
           {
               Number = 15,
               Month = Months.February
           };

           Console.WriteLine(dayOfYear.Month == dayOfYear2.Month);

           Console.WriteLine($"{dayOfYear.Number} {dayOfYear.Month}");
           Console.WriteLine($"{dayOfYear2.Number} {dayOfYear2.Month}");

        }
    }
}
