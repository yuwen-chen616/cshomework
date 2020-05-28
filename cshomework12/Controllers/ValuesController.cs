using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderdb;
        public OrderController(OrderContext context){
            this.orderdb = context;
            
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
             if (orderdb.Orders.Count()==0)
            {
                orderdb.Orders.Add(new Order());
                orderdb.SaveChanges();
            }
            IQueryable<Order> query = orderdb.Orders;
           
    
            return query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            var order = orderdb.Orders.FirstOrDefault(t => t.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Order> Post(Order order)
        {
            try{
                orderdb.Orders.Add(order);
                orderdb.SaveChanges();
            }catch(Exception e ){
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put(string ID,Order order)
        {
            if(ID!= order.ID){
                return BadRequest("id cannot be modified!");
            }
            try{
                orderdb.Entry(order).State = EntityState.Modified;
                orderdb.SaveChanges();
            }catch(Exception e){
                string error = e.Message;
                if(e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try{
                var order = orderdb.Orders.FirstOrDefault(t => t.ID == id);
                if(order != null){
                    orderdb.Remove(orderdb);
                    orderdb.SaveChanges();
                }
                }catch(Exception e){
                    return BadRequest(e.InnerException.Message);
                }
                return NoContent();
            }
        }
    }

