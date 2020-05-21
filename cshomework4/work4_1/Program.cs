using System;

namespace work4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)   // foreach 函数
        {
            for (Node<T> node = head;
             node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = 0;
            int min = 0;
            GenericList<int> intList = new GenericList<int>();
            for (int i = 0; i < 10; i++)//初始化链表
            {
                intList.Add(i);
            }
            intList.ForEach(num => Console.Write(num + " ")); // 遍历输出
            intList.ForEach(num => sum += num); //计算和
            intList.ForEach(num => max = max > num ? max : num);// 计算最大值
            intList.ForEach(num => min = min < num ? min : num);// 计算最小值
            Console.WriteLine("\n" + "the sum is :" + sum); //输出
            Console.WriteLine("the max is :" + max);
            Console.WriteLine("the min is :" + min);
        }
    }
}
