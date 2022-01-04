using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Book
    {
        public int ID { get; set; }
        //numele revistei
        public string Title { get; set; }
        //domeniul
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        //pretul
        public decimal Price { get; set; }
        //comenzi
        public ICollection<Order> Orders { get; set; }
        //magazine
        public ICollection<PublishedBook> PublishedBooks { get; set; }

    }
}
