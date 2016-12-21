using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoughnutShop.Models
{
    public class DoughnutShopDbContext : DbContext
    {
        public DbSet<Doughnut> Doughnut { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<DoughnutOrder> DoughnutOrder { get; set; }
    }
}

/*
 * PM> Enable-Migrations -ContextTypeName DoughnutShop.Models.DoughnutShopDbContext
 * PM> Add-Migration DoughnutShopMigration
 * Name: DoughnutShopMigration
 * 
 * namespace DoughnutShop.Migrations
{
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Models;

internal sealed class Configuration : DbMigrationsConfiguration<DoughnutShop.Models.DoughnutShopDbContext>
{
public Configuration()
{
AutomaticMigrationsEnabled = false;
}

protected override void Seed(DoughnutShop.Models.DoughnutShopDbContext context)
{
// new users
context.User.AddOrUpdate(p => p.Name,
new User
{
Id = 0,
Name = "Admin",
Role = "admin",
Email = "angelina.bylitskaya@gmail.com",
Password = "1qazXSW@"
},
new User
{
Id = 1,
Name = "Ilya Vrublevski",
Role = "manager",
Email = "ilya.vrublevsky@gmail.com",
Password = "1qazXSW@"
},
new User
{
Id = 2,
Name = "Arseni Rozhok",
Role = "client",
Email = "rozhok.arseni@gmail.com",
Password = "1qazXSW@"
});

// new doughnuts
//context.Doughnut.AddOrUpdate(p => p.Name,
//   new Doughnut
//   {
//       Name = "Gawai Doughnut",
//       Description = "Mamb 1! Best of the best!",
//       Price = 1.3
//   },
//   new Doughnut
//   {
//       Name = "German Doughnut",
//       Description = "Delicious Doughnut with German sausages! Perfect for beer!",
//       Price = 1.3
//   },
//   new Doughnut
//   {
//       Name = "Sweet Doughnut",
//       Description = "Favourite doughnut of sweet tooth!",
//       Price = 1.3
//   });

// new order
//DoughnutOrder[] DoughnutOrder =
//{
//    new DoughnutOrder {
//        Doughnut = {
//            Name = "Gawai Doughnut",
//            Description = "Mamb 1! Best of the best!",
//            Price = 1.3
//        },
//        count = 2
//    },
//    new DoughnutOrder {
//        Doughnut = {
//            Name = "Sweet Doughnut",
//            Description = "Favourite doughnut of sweet tooth!",
//            Price = 1.3
//        },
//        count = 5
//    }
//};

//Order newOrder = new Order
//{
//    UserId = 0,
//    DoughnutOrder = DoughnutOrder,
//    Date = DateTime.Now,

//};

//context.Order.AddOrUpdate(p => p.Date,
//    newOrder);
}
}
}

 *
 * update-database 
 */
