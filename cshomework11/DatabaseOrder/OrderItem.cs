using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOrder
{
    public class OrderItem
    {
        [Key]
        public string ID { get; set; }
        public string OrderID { get; set; }
        public string NAME { get; set; }
        public int Prize { get; set; }
        public int Num { get; set; }
        public OrderItem(string name, int num, int prize)
        {
            ID = Guid.NewGuid().ToString();
            NAME = name;
            Num = num;
            Prize = prize;
        }
        public OrderItem()
        {
            ID = Guid.NewGuid().ToString();
            NAME = "";
            Prize = new int();
            Num = new int();
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   ID == item.ID &&
                   OrderID == item.OrderID &&
                   NAME == item.NAME &&
                   Prize == item.Prize &&
                   Num == item.Num;
        }

        public override int GetHashCode()
        {
            var hashCode = 173058602;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NAME);
            hashCode = hashCode * -1521134295 + Prize.GetHashCode();
            hashCode = hashCode * -1521134295 + Num.GetHashCode();
            return hashCode;
        }
    }
}
