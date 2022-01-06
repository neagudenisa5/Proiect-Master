using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        //clienti
        public DbSet<Customer> Customers { get; set; }
        //comenzi
        public DbSet<Order> Orders { get; set; }
        //reviste
        public DbSet<Book> Books { get; set; }
        //magazine
        public DbSet<Publisher> Publishers { get; set; }
        //reviste prezente in magazine spre vanzare
        public DbSet<PublishedBook> PublishedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<PublishedBook>().ToTable("PublishedBook");
            modelBuilder.Entity<PublishedBook>()
            .HasKey(c => new { c.BookID, c.PublisherID });//configureaza cheia primara compusa intre revista si magazin
        }
    }
}
