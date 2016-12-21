using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoughnutShop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<int> OrdersId { get; set; }

        public virtual List<Order> Orders { get; set; }

        public User() { }

        public User(User u)
        {
            Name = u.Name;
            Role = u.Role;
            Email = u.Email;
            Orders = Orders;
            Password = UserCredentials.EncryptSHA512Managed(u.Password);
        }

        public void Update(User u)
        {
            Name = u.Name;
            Role = u.Role;
            Email = u.Email;
            Orders = Orders;
        }
    }
}