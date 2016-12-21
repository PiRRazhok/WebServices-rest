using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoughnutShop.Models
{
    public class DoughnutOrder
    {
        [Key]
        public int Id { get; set; }

        public int DoughnutId { get; set; }

        public virtual Doughnut Doughnut { get; set; }

        public int count { get; set; }
    }
}