using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YearOfWeekend01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入西元年份");
            int adYear = int.Parse(Console.ReadLine());
            int daysInYear;
            if (DateTime.IsLeapYear(adYear))
            {
                daysInYear = 366;
            }
            else
            {
                daysInYear = 365;
            }

            int saturdayCount = 0;
            int sundayCount = 0;
            DateTime firstDay = new DateTime(adYear, 1, 1);
            for (int i = 0; i < daysInYear; i++)
            {
                DateTime currentDay = firstDay.AddDays(i);
                if (currentDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                else if(currentDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }
            Console.WriteLine($"星期六{saturdayCount}天，星期日{sundayCount}天");

        }
    }
}
