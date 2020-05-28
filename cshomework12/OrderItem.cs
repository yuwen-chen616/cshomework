using System;
namespace TodoApi.Models{
public class OrderItem{
    public string ID{get;set;}
    public string OrderID{get;set;}
    public string NAME{get;set;}
    public OrderItem(){
        ID = Guid.NewGuid().ToString();
        NAME = "";
    }

}}