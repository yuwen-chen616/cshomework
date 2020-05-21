using System;

namespace work2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[101];
            for (int i = 2; i < num.Length - 1; i++)
            {
                num[i] = i;
            }
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 1; i * j <= num.Length - 1; j++)
                {
                    num[i * j] = 0;
                }

            }
            Console.WriteLine("2-100之间的素数有:");

            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] != 0)
                {
                    Console.WriteLine(num[i]);
                }

            }
        }
    }
}
