using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOrder
{
    public class Order: IComparable<Order>
    {
        [Key]
        public string ID { get; set; }
        public string Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public int TotalPrize
        {
            get
            {
                int total = 0;
                if (OrderItems == null) return total;

                foreach (OrderItem item in OrderItems)
                {
                    total += item.Prize * item.Num;
                }
                return total;
            }

        }

        public Order()
        {
            //  OrderItem item = new OrderItem();
            OrderItems = new List<OrderItem>();
            //OrderItems.Add(item)
            ID = Guid.NewGuid().ToString();
            Customer = "";
        }
        public Order(List<OrderItem> items, string customer)
        {
            OrderItems = items;
            ID = Guid.NewGuid().ToString();
            Customer = customer;


        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.ID.CompareTo(other.ID);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   ID == order.ID &&
                   Customer == order.Customer &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(OrderItems, order.OrderItems) &&
                   TotalPrize == order.TotalPrize;
        }

        public override int GetHashCode()
        {
            var hashCode = 1549966817;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + TotalPrize.GetHashCode();
            return hashCode;
        }
    }

}
