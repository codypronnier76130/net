using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Postcode { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Provider> Providers { get; set; }

        public int AdminID { get; set; }
    }
}
