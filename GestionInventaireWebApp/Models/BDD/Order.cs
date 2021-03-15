﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; } 
        public bool IsActive { get; set; }
        public User User { get; set; }
        public ICollection<OrderArticle> OrderArticles { get; set; }
        public Stock Stock { get; set; }
        public Admin Admin { get; set; }
        public int AdminID { get; set; }


    }
}
