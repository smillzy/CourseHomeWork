using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace OddsOrEvens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串整數數字");
            string[] input = Console.ReadLine().Split(",");
            int oddCount = 0;
            int evenCount = 0;

            foreach (string num in input)
            {
                int value = int.Parse(num);

                if (value % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] odd = new int[oddCount];
            int[] even = new int[evenCount];

            int oddIndex = 0;
            int evenIndex = 0;

            foreach (string num in input)
            {
                int value = int.Parse(num);

                if (value % 2 == 0)
                {
                    even[evenIndex] = value;
                    evenIndex++;
                }
                else
                {
                    odd[oddIndex] = value;
                    oddIndex++;
                }
            }

            Array.Sort(odd);
            Array.Sort(even);

            Console.WriteLine("奇數：" + string.Join(",", odd));
            Console.WriteLine("偶數：" + string.Join(",", even));

        }
    }
}
