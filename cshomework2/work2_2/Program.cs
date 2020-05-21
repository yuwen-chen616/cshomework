using System;

namespace work2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("输入数组元素个数：");
            int length = Int32.Parse(Console.ReadLine());
         
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                    Console.WriteLine($"输入第{i + 1}个数组元素");
                    array[i] = Int32.Parse(Console.ReadLine());
            }
            int max, min, average, sum;
            CalcArray(array, out max, out min, out average, out sum);
            Console.WriteLine($"数组的最大值为{max}");
            Console.WriteLine($"数组的最小值为{min}");
            Console.WriteLine($"数组的平均值为{average}");
            Console.WriteLine($"所有数组元素的和为{sum}");
            
        }

        //计算数组元素的最大值，最小值，平均值，总和。
        static void CalcArray(int[] array, out int max, out int min, out int average, out int sum)
        {
            max = min = array[0];
            sum = 0;
            foreach (int n in array)
            {
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
                sum += n;
            }
            average = sum / array.Length;
        }
    }
}
