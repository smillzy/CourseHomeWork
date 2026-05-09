namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //請輸入一個整數數字，判斷其結果為奇數或偶數，並且在 Console 上顯示結果
            Console.WriteLine("請輸入一個整數數字");
            string input = Console.ReadLine();
            if (int.Parse(input) % 2 == 0)
            {
                Console.WriteLine("偶數");
            }
            else
            {
                Console.WriteLine("奇數");
            }
        }
    }
}
