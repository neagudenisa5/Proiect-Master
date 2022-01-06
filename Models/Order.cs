using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Order
    {
        //id-ul comenzii
        public int OrderID { get; set; }
        //id-ul clientului care a facut comanda
        public int CustomerID { get; set; }
        //id-ul revistei
        public int BookID { get; set; }
        //clientul care a facut comanda
        public Customer Customer { get; set; }
        //revista cumparata
        public Book Book { get; set; }
        //data
        public DateTime OrderDate { get; set; }
    }
}
