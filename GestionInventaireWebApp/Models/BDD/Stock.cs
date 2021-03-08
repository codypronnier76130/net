﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Article> Articles { get; set; }

        public ICollection<Order> Orders { get; set;}
     
    }
}
