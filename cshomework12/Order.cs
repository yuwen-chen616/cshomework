using System.Collections.Generic;
using System;
namespace TodoApi.Models{


public class Order{
    public string ID{get;set;}
    public List<OrderItem> orderItems;
    public Order(){
        ID = Guid.NewGuid().ToString();
        orderItems = new List<OrderItem>();
    }
}
}