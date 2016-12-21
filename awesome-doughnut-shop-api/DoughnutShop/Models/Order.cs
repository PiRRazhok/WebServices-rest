using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoughnutShop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User user { get; set; }

        public List<int> DoughnutOrdersId { get; set; }

        public virtual List<DoughnutOrder> DoughnutOrders { get; set; }

        public DateTime Date { get; set; }
        
        public double TotalPrice { get; set; }

        public void Update(Order o)
        {
            DoughnutOrdersId = o.DoughnutOrdersId;
            Date = DateTime.Now;
            //TotalPrice = 
        }
    }
}
