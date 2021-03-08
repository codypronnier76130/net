﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class Admin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Name { get; set; }

        public ICollection<Stock> Stocks { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Provider> Providers { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<Type> Types { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
