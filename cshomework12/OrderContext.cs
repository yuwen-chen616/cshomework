using System;
using Microsoft.EntityFrameworkCore;

    
namespace TodoApi.Models{
public class OrderContext:DbContext{
    public OrderContext(DbContextOptions <OrderContext> options):base(options){
        this.Database.EnsureCreated();
    }

    public DbSet<Order> Orders{get;set;}
    public DbSet<OrderItem> OrderItems{get;set;}
}
}