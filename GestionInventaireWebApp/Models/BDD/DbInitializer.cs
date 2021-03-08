using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class DbInitializer
    {
        public static void Initialize(NetContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Admins.Any())
            {
                return;   // DB has been seeded
            }

            var admin = new Admin[]
            {
                new Admin { Name = "Carson", Email = "admin@gmail.com"},
            };

            context.Admins.AddRange(admin);
            context.SaveChanges();

            var article = new Article[]
            {
                new Article { Name = "Vin Rouge", CreateDate = DateTime.Parse("2020-08-09"), BuyPrice = 50, SellPrice = 40}
            };

            context.SaveChanges();

            var city = new City[]
            {
                new City { Name = "Rouen", Postcode = 76000}
            };

            context.SaveChanges();

            var order = new Order[]
            {
                new Order { OrderDate = DateTime.Parse("2020-08-09"), OrderQuantity = 10, IsActive = false}
            };

            context.SaveChanges();
            var provider = new Provider[]
            {
                new Provider { Name = "Link", Email = "provider@gmail.com", Address = "15 Rue du chevreuil", PhoneNumber = "07 45 86 95 42"}
            };

            context.SaveChanges();

            var stock = new Stock[]
            {
                new Stock { Quantity = 15}
            };

            context.SaveChanges();

            var type = new Type[]
            {
                new Type { Name = "Blanc"}
            };

            context.SaveChanges();

            var user = new User[]
            {
                new User { LastName = "Blanc", FirstName = "Francis", Email = "user@gmail.com", Address = "123 Impasse de la tour"}
            };

            context.SaveChanges();






        }
    
}
}
