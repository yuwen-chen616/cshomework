using System;

namespace work3_shape
{
    interface Shape
    {
        double GetArea();
        bool IsLegal();
        void Print();
    }

    class Rectangle : Shape
    {
        double length { get; set; }
        double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public bool IsLegal()
        {
            return length > 0 && width > 0;
        }

        public void Print()
        {
            Console.WriteLine($"长方形：长为{length},宽为{width}");
        }
    }

    class Square : Shape
    {
        double sideLength { get; set; }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public bool IsLegal()
        {
            return sideLength > 0;
        }

        public void Print()
        {
            Console.WriteLine($"正方形：边长为{sideLength}");
        }
    }

    class Triangle : Shape
    {
        double firstSide { get; set; }
        double secondSide { get; set; }
        double thirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public double GetArea()
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        public bool IsLegal()
        {
            return firstSide + secondSide > thirdSide
                && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide
                && firstSide > 0 && secondSide > 0 && thirdSide > 0;
        }

        public void Print()
        {
            Console.WriteLine($"三角形：三边长分别为{firstSide}、{secondSide}、{thirdSide}");
        }
    }

    class ShapeFactory
    {
        private static Shape newShape = null;
        public static Shape Create(int type)
        {
            Random rd = new Random();
            switch (type)
            {
                case 1:
                    newShape = new Rectangle(rd.Next(1, 100), rd.Next(1, 100));
                    break;
                case 2:
                    newShape = new Square(rd.Next(1, 100));
                    break;
                case 3:
                    newShape = new Triangle(rd.Next(1, 100), rd.Next(1, 100), rd.Next(1, 100));
                    break;
                default:
                    break;
            }
            return newShape;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double sumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                Shape x = ShapeFactory.Create(rd.Next(1, 3));
                Console.WriteLine($"第{i + 1}个图形面积为{x.GetArea()}.");
                sumArea += x.GetArea();
            }
            Console.WriteLine($"面积总和为{sumArea}.");
            Console.ReadKey();
        }
    }
}
