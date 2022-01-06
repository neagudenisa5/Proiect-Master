using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Publisher
    {
        //ID reprezinta id-ul magazinului
        public int ID { get; set; }
        //numele magazinului, lungime maxima 50 caractere
        [Required]
        [Display(Name = "Numele Magazinului")]
        [StringLength(50)]
        public string PublisherName { get; set; }
        //adresa magazinului, maxim 70 de caractere
        [StringLength(70)]
        public string Adress { get; set; }
        //o revista poate fi vanduta de mai multe magazine in acelasi timp
        public ICollection<PublishedBook> PublishedBooks { get; set; }

    }
}

