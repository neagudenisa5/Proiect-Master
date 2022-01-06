using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models.LibraryViewModels
{
    public class PublishedBookData
    {
        //id-ul revistei
        public int BookID { get; set; }
        //titlul
        public string Title { get; set; }
        //daca este vanduta intr-un magazin sau nu
        public bool IsPublished { get; set; }
    }
}
