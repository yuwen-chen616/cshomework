using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using System.Threading.Tasks;

namespace DatabaseOrder
{
    class OrderContext:DbContext
    {
       
        public OrderContext() : base("orderDatabase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderContext>());
            Console.WriteLine("successfully");
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }

   

}

