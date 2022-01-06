using System;
using System.ComponentModel.DataAnnotations;
namespace Proiect.Models.LibraryViewModels
{
    public class OrderGroup
    {
        //data comenzii
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        //numarul de reviste vandute intr-o anumita data
        public int BookCount { get; set; }

    }
}