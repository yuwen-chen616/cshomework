using System;

namespace csHomework1_Calculator2
{
    class Program
    {
        static int TobeInt()
        {
            string str = Console.ReadLine();
            bool IsInt;//判断输入的字符是否为整数
            int num;
            IsInt = int.TryParse(str, out num);
            while (!IsInt)
            {
                Console.WriteLine("输入的字符不是整数，请重新输入！");
            }
            return num;
        }
        static void Main(string[] args)
        {
            int a, b,opt;
            Console.WriteLine("输入第一个数字：");
            a = TobeInt();
            Console.WriteLine("输入第二个数字：");
            b = TobeInt();
            Console.WriteLine("请选择运算符：");
            opt = TobeInt();
            while(opt<1||opt>4)
            {
                Console.WriteLine("输入的运算符不存在，请重新输入！");
            }
            switch(opt)
            {
                case 1:
                    Console.WriteLine("两个数的和为：{0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("两个数的差为：{0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("两个数的乘积为：{0}", a * b);
                    break;
                case 4:
                    if(b==0)
                    {
                        Console.WriteLine("错误！");
                    }
                    else
                    {
                        Console.WriteLine("两个数的商为：{0}", a / b);
                    }
                    break;
            }   
        }
        
    }
}
