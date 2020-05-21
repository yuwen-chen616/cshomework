using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

// 1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
// 2、对订单程序中OrderService的各个Public方法添加测试用例。

namespace Homework_OrderSerialization
{
    public class OrderItem
    {

        public int Index { get; set; } //编号
        public String GoodsName { get; set; } //商品名
        public double Price { get; set; } //价格
        public int Quantity { get; set; } //数量
        public double TotalPrice { get => Price * Quantity; }

        public OrderItem() { }

        public OrderItem(int index, String goodsName, double price, int quantity)
        {
            this.Index = index;
            this.GoodsName = goodsName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $" 编号:{Index},商品名:{GoodsName},数量:{Quantity},总价格:{TotalPrice} ";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null && GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }

    public class Order : IComparable<Order>
    {
        private List<OrderItem> items;
        public int OrderId { get; set; }
        public String Customer { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderItem> Items { get { return items; } }
        public double TotalPrice { get => items.Sum(item => item.TotalPrice); }

        public Order() { items = new List<OrderItem>(); OrderTime = DateTime.Now; }

        public Order(int orderId, string customer, List<OrderItem> items)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.items = items;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strshow = new StringBuilder();
            strshow.Append($"编号:{OrderId}, 顾客:{Customer},下单时间:{OrderTime},总价格：{TotalPrice}");
            items.ForEach(oder => strshow.Append("\n\t" + oder));
            return strshow.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + OrderTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }
    }

    public class OrderService
    {

        private List<Order> orders;
        public List<Order> Orders { get => orders; }
        public OrderService()
        {
            orders = new List<Order>();
        }

        public Order GetOrder(int id)
        {
            return orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order order = GetOrder(orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
        }

        public List<Order> QueryByCustomerName(string customerName)
        {//lamda表达式
            return orders.Where(order => order.Customer == customerName).OrderBy(ord => ord.TotalPrice).ToList();
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {//lamda表达式
            var query = orders.Where(order => order.Items.Exists(item => item.GoodsName == goodsName)).OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public void Sort()
        {
            orders.Sort();
        }

        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((ord1, ord2) => func(ord1, ord2));
        }

        public void Export(String fileName)
        {
            XmlSerializer xmlSerial = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlSerial.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xmlSerial = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerial.Deserialize(fs);
                temp.ForEach(order => {if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            //创建商品
            OrderItem computer = new OrderItem(1, "computer", 5, 4000);
            OrderItem airpods = new OrderItem(2, "airpods", 20, 999);
            OrderItem oil = new OrderItem(3, "oil", 1000.5, 10);
            //创建订单
            Order ord1 = new Order(1, "cyw", new List<OrderItem> { computer, airpods });
            Order ord2 = new Order(2, "wqf", new List<OrderItem> { airpods, oil });
            Order ord3 = new Order(3, "bonnie", new List<OrderItem> { computer, airpods, oil });
            //创建订单服务
            OrderService os = new OrderService();
            os.AddOrder(ord1);
            os.AddOrder(ord2);
            os.AddOrder(ord3);
            os.Export("./orderssave.xml");

            Console.WriteLine("打印全部订单：");
            List<Order> orders = os.Orders;
            orders.ForEach(ord => Console.WriteLine(ord));
            Console.WriteLine("");

            os.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
            Console.WriteLine("打印排序后的订单：");
            orders = os.Orders;
            orders.ForEach(ord => Console.WriteLine(ord));
            Console.WriteLine("");

            Console.WriteLine("打印顾客cyw的订单：");
            orders = os.QueryByCustomerName("cyw");
            orders.ForEach(ord => Console.WriteLine(ord));
            Console.WriteLine("");

            Console.WriteLine("打印有computer的订单：");
            orders = os.QueryByGoodsName("computer");
            orders.ForEach(ord => Console.WriteLine(ord));
            Console.WriteLine("");

            Console.WriteLine("从文件中反序列化出订单：");
            OrderService osnew = new OrderService();
            osnew.Import("./orderssave.xml");
            osnew.Orders.ForEach(order => Console.WriteLine(order));
            Console.WriteLine("");

            Console.WriteLine("请输入要删除的订单的编号：");
            // 接收用户输入，为变量赋值
            string input = Console.ReadLine();
            int id = int.Parse(input);  //比如2
            os.RemoveOrder(id);
            Console.WriteLine("打印修改后的订单：");
            orders.ForEach(ord => Console.WriteLine(ord));
            Console.WriteLine(id);
            Console.WriteLine("");
        }
    }
}
