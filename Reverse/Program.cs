using System.Security.Cryptography;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串整數數字");
            string[] input = Console.ReadLine().Split(",");
            for(int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);

                if (i > 0)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
