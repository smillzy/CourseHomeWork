namespace OddOrEvenLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串以逗號分隔的整數數字");
            string input = Console.ReadLine();
            //var groups = input
            //             .Split(',')
            //             .Select(x => int.Parse(x.Trim()))
            //             .GroupBy(x => x % 2 == 0 ? "偶數" : "奇數");
            // https://learn.microsoft.com/zh-tw/dotnet/api/system.array?view=net-10.0
            // how to invoke Select
            // go to the method definition
            // extension method
            //public static IEnumerable<TResult> Select<TSource, TResult>(
            //this IEnumerable<TSource> source, Func<TSource, TResult> selector)
            // input parameter: 
            // 1. this IEnumerable<TSource> source
            // 2. Func<TSource, TResult> selector
            // return IEnumerable<TResult> 

            // 1. SELECT method first parameter must IEnumberable<TSource>
            // implement iterator like getEnumerator, and the move next step are IEnumerable<TSource>
            // 2. string[] is IEnumberable<string> 
            // 3. array, list, dictionary
            // Func<TSource, TResult> selector => accept TSource. return TResult
            // return IEnumerable<TResult> by method signature



            var result = Enumerable.Select(input
                         .Split(','), x => int.Parse(x.Trim()));
            var groups1 = input
                         .Split(',')
                         .Select<string, int>(x => int.Parse(x.Trim()));
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

    public class Class2
    {
        public Class2()
        {
            DoSomething parseStringToInt1 = x => int.Parse(x);
            Func<string, int> parseStringToInt = x => int.Parse(x);
            string input = Console.ReadLine();
            var groups = input
                         .Split(',')
                         .Select(parseStringToInt);
        }
    }

    public delegate int DoSomething(string str);

}
