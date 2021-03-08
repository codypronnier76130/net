﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
        public City City { get; set; }
        public Admin Admin { get; set; }
    }
}