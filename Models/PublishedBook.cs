using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class PublishedBook
    {
        //id-ul magazinului
        public int PublisherID { get; set; }
        //id-ul revistei
        public int BookID { get; set; }
        //magazinul
        public Publisher Publisher { get; set; }
        //revista
        public Book Book { get; set; }
    }
}
