namespace ReverseLinq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字：");

            int input = int.Parse(Console.ReadLine());

            var result = Enumerable.Range(1, input)
                .Select(i => string.Concat(Enumerable.Repeat((input - i + 1).ToString(), i)));

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
