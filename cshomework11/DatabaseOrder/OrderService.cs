using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOrder
{
   public class OrderService
    {

        public OrderService()
        {
        }
        private static IQueryable<Order> AllOrders(OrderContext db)
        {
            return db.Orders.Include("OrderItems");
                    
        }
        public static List<Order> GetAllOrders()
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).ToList();
            }
        }

        public static Order GetOrder(string id)
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).FirstOrDefault(o => o.ID == id);
            }
        }

        public static Order AddOrder(Order order)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                return order;
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"添加错误: {e.Message}");
            }
        }

        public static void RemoveOrder(string id)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = db.Orders.Include("OrderItems").Where(o => o.ID == id).FirstOrDefault();
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"删除订单错误!");
            }
        }

        public static void UpdateOrder(Order newOrder)
        {
            RemoveItems(newOrder.ID);
            using (var db = new OrderContext())
            {
                db.Entry(newOrder).State = EntityState.Modified;
                newOrder.Customer = newOrder.Customer;
                db.OrderItems.AddRange(newOrder.OrderItems);
                db.SaveChanges();
            }
        }
      
        private static void RemoveItems(string orderId)
        {
            using (var db = new OrderContext())
            {
                var oldItems = db.OrderItems.Where(item => item.OrderID == orderId);
                db.OrderItems.RemoveRange(oldItems);
                db.SaveChanges();
            }
        }
        public static void RemoveItem(OrderItem Item)
        {
            using (var db = new OrderContext())
            {
                var oldItem = db.OrderItems.Where(item => item.OrderID == Item.ID);
                db.OrderItems.RemoveRange(oldItem);
                db.SaveChanges();
            }
        }
        public static List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db)
                  .Where(o => o.Customer == customerName);
                return query.ToList();
            }
        }
        public static List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db)
                  .Where(o => o.OrderItems.Count(i => i.NAME == goodsName) > 0);
                return query.ToList();
            }
        }

    }
}
