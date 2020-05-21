using System;

namespace work2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入指定数据：");
            string s = Console.ReadLine();
            int num = Int32.Parse(s);
            if (num <= 1)
                Console.WriteLine($"输入的整数{num}没有素数因子");
            else
            {
                Console.WriteLine($"{num}的素数因子为：");
                for (int i = 2; i <= num; i++)
                {
                    //i为num的因数且i为质数，则输出i。
                    if (num % i == 0 && IsPrimeNum(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        //判断number是否为质数，为质数则返回true，反之返回false。
        static bool IsPrimeNum(int number)
        {
            int i;
            for (i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    break;
            }
            if (i == number)
                return true;
            else
                return false;
        }
    }
}
