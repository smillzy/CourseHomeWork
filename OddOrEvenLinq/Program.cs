namespace OddOrEvenLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的整數數字");
            string input = Console.ReadLine();
            var groups = input
                         .Split(',')
                         .Select(x => int.Parse(x.Trim()))
                         .GroupBy(x => x % 2 == 0 ? "偶數" : "奇數");

            foreach (var gp in groups)
            {
                Console.WriteLine(gp.Key + "：" + string.Join(",", gp.OrderBy(x => x)));
            }

        }
    }
}
