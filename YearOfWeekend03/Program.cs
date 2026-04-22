namespace YearOfWeekend03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入民國年份");
            int rocYear = int.Parse(Console.ReadLine());
            int year = rocYear + 1911;

            int saturdayCount = 52;
            int sundayCount = 52;

            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime secondDay = firstDay.AddDays(1);

            if (firstDay.DayOfWeek == DayOfWeek.Saturday || (DateTime.IsLeapYear(year) && secondDay.DayOfWeek == DayOfWeek.Saturday))
            {
                saturdayCount++;
            }

            if (firstDay.DayOfWeek == DayOfWeek.Sunday || (DateTime.IsLeapYear(year) && secondDay.DayOfWeek == DayOfWeek.Sunday))
            {
                sundayCount++;
            }

            Console.WriteLine($"星期六{saturdayCount}天，星期日{sundayCount}天");
        }
    }
}
