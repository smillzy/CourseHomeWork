namespace ReverseTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{input-i}");
                }
                Console.WriteLine();
            }
        }
    }
}
