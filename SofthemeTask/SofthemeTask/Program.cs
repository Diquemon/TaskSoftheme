using System;

namespace SofthemeTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Program().solution();
            Console.ReadKey();
        }

        public void solution()
        {
            int result = 0;
            int[] degrees = new int[10];
            for (int i = 0; i < 10; i++)
            {
                degrees[i] = i;
                for (int j = 1; j < 5; j++)
                {
                    degrees[i] *= i;
                }
            }
            for (int i = 100; i < 354294; i++)
            {
                int sumOfPowers = 0, number = i;
                while (number > 0)
                {
                    sumOfPowers += degrees[number % 10];
                    number /= 10;
                }
                if (sumOfPowers == i)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result is {0}", result);
        }
    }
}
