using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoughnutShop.Models
{
    public class Doughnut
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public void Update(Doughnut newDoughnut)
        {
            this.Name = newDoughnut.Name;
            this.Description = newDoughnut.Description;
            this.Price = newDoughnut.Price;
        }
    }
}