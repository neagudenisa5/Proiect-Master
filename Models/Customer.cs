using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //id-ul clientului
        public int CustomerID { get; set; }
        //numele
        public string Name { get; set; }
        //adresa
        public string Adress { get; set; }
        //data nasterii
        public DateTime BirthDate { get; set; }
        //comenzile efectuate de client
        public ICollection<Order> Orders { get; set; }

    }
}
