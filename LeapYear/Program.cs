namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個中華民國年份");
            int rocYear = int.Parse(Console.ReadLine());
            int adYear = rocYear + 1911;

            //adYear % 400 == 0 || (adYear % 4 == 0 && adYear % 100 != 0)
            if (DateTime.IsLeapYear(adYear))
            {
                Console.WriteLine("是閏年");
            }
            else {
                Console.WriteLine("不是閏年");
            }
           
        }
    }
}
