namespace ReverseLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串整數數字");
            string input = Console.ReadLine();
            string result = string.Join(",", input.Split(',').Reverse());
            Console.WriteLine(result);
        }
    }
}
