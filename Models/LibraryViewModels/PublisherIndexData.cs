using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proiect.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        //magazine
        public IEnumerable<Publisher> Publishers { get; set; }
        //reviste
        public IEnumerable<Book> Books { get; set; }
        //comenzi
        public IEnumerable<Order> Orders { get; set; }
    }
}
