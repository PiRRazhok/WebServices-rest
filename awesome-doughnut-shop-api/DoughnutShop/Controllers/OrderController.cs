using DoughnutShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoughnutShop.Controllers
{
    public class OrderController : ApiController
    {
        private DoughnutShopDbContext db = new DoughnutShopDbContext();

        [HttpGet]
        [Route("orders")]
        public IEnumerable<Order> GetAll()
        {

            List<Order> orders = db.Order.ToList();

            return orders;
        }

        [HttpGet]
        [Route("orders/{id}")]
        public IHttpActionResult Get(int id)
        {

            Order order = db.Order.Find(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpGet]
        [Route("orders/user/{userId}")]
        public IHttpActionResult GetByUserId(int userId)
        {

            IEnumerable<Order> orders = db.Order.ToList().Where(o => o.UserId == userId);

            return Ok(orders);
        }

        [HttpPost]
        [Route("orders")]
        public IHttpActionResult Create([FromBody]Order order)
        {
            db.Order.Add(order);
            db.SaveChanges();

            return Ok(order);
        }

        [HttpPut]
        [Route("orders")]
        public IHttpActionResult Update([FromBody]Order newOrder)
        {
            Order order = db.Order.First((o) => o.Id == newOrder.Id);
            order.Update(newOrder);
            db.SaveChanges();

            return Ok(order);
        }

        [HttpDelete]
        [Route("orders/{id}")]
        public IHttpActionResult Delete(int id)
        {
            Order order = db.Order.First((u) => u.Id == id);
            db.Order.Remove(order);
            db.SaveChanges();

            return Ok();
        }
    }
}
