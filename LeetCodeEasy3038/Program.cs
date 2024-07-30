namespace LeetCodeEasy3038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Solution.MaxOperations([3, 2, 1, 4, 5]); 
            if (result1 != 2)
            {
                Console.WriteLine($"result1 is: {result1} instead of 2");
                return; 
            }
            int result2 = Solution.MaxOperations([3, 2, 6, 1, 4]);
            if (result2 != 1)
            {
                Console.WriteLine($"result2 is: {result2} instead of 1");
                return;
            }

            int result3 = Solution.MaxOperations([4, 3, 3, 4, 10]);
            if (result3 != 2)
            {
                Console.WriteLine($"result3 is: {result3} instead of 2");
                return;
            }
            Console.WriteLine($"it works perfectly!");
        }
    }
}
