
using Proiect.Data;
using Proiect.Models;
using System;
using System.Linq;

namespace Proiect.Data
{
    public class DbInitializer
    {
        //adaugare date in baza de date
            public static void Initialize(LibraryContext context)
            {
                context.Database.EnsureCreated();
                if (context.Books.Any())
                {
                    return; // baza de date a fost deja creata
                }
                var books = new Book[]
                {
                    new Book{Title="Norocel",Author="copii",Price=Decimal.Parse("14")},
                    new Book{Title="Bravo",Author="adolescenti",Price=Decimal.Parse("35")},
                    new Book{Title="Sanatatea ta e importanta",Author="nutritie",Price=Decimal.Parse("89")},
                    new Book{Title="ELLE",Author="moda",Price=Decimal.Parse("15")},
                    new Book{Title="Reteta zilei",Author="culinar",Price=Decimal.Parse("27")},
                    new Book{Title="The One",Author="femei",Price=Decimal.Parse("21")},
                    new Book{Title="TVmania",Author="televiziune",Price=Decimal.Parse("19")},
                    new Book{Title="Men's Health",Author="barbati",Price=Decimal.Parse("23")},
                    new Book{Title="Ziarul financiar",Author="economie",Price=Decimal.Parse("25")},
                    new Book{Title="Casa Mea",Author="ingrijirea casei",Price=Decimal.Parse("40")},
                    new Book{Title="Promotor",Author="auto",Price=Decimal.Parse("43")},

                };
                foreach (Book b in books)
                {
                    context.Books.Add(b);
                }
                context.SaveChanges();
                var customers = new Customer[]
                {

                    new Customer{CustomerID=1010,Name="Neagu Denisa",BirthDate=DateTime.Parse("1999-04-05")},
                    new Customer{CustomerID=1020,Name="Voicu Lavinia",BirthDate=DateTime.Parse("1999-05-06")},
                    new Customer{CustomerID=1030,Name="Stanciu Alex",BirthDate=DateTime.Parse("2000-07-07")},
                    new Customer{CustomerID=1040,Name="Zaharia Alexandru",BirthDate=DateTime.Parse("1996-10-13")},
                    new Customer{CustomerID=1050,Name="Popa George",BirthDate=DateTime.Parse("1994-12-25")},
                    new Customer{CustomerID=1060,Name="Ivan Antonia",BirthDate=DateTime.Parse("2013-06-20")},
                    new Customer{CustomerID=1070,Name="Popescu Alina",BirthDate=DateTime.Parse("1978-08-01")},


                };
                foreach (Customer c in customers)
                {
                    context.Customers.Add(c);
                }
                context.SaveChanges();
                var orders = new Order[]
                {
                    new Order{BookID=1,CustomerID=1010,OrderDate=DateTime.Parse("2021-08-05")},
                    new Order{BookID=6,CustomerID=1010,OrderDate=DateTime.Parse("2021-08-05")},
                    new Order{BookID=3,CustomerID=1070,OrderDate=DateTime.Parse("2021-09-25")},
                    new Order{BookID=4,CustomerID=1060,OrderDate=DateTime.Parse("2021-03-02")},
                    new Order{BookID=4,CustomerID=1050,OrderDate=DateTime.Parse("2021-02-03")},
                    new Order{BookID=2,CustomerID=1030,OrderDate=DateTime.Parse("2021-07-07")},
                    new Order{BookID=2,CustomerID=1020,OrderDate=DateTime.Parse("2021-08-19")},
                    new Order{BookID=2,CustomerID=1060,OrderDate=DateTime.Parse("2021-03-02")},
                    new Order{BookID=1,CustomerID=1040,OrderDate=DateTime.Parse("2021-10-10")},
                    new Order{BookID=1,CustomerID=1010,OrderDate=DateTime.Parse("2021-08-05")},
                    new Order{BookID=3,CustomerID=1020,OrderDate=DateTime.Parse("2021-12-18")},
                };
                foreach (Order e in orders)
                {
                    context.Orders.Add(e);
                }
                context.SaveChanges();
                var publishers = new Publisher[]
                {

                    new Publisher{PublisherName="Bookidz",Adress="Str. Motilor, Cluj-Napoca"},
                    new Publisher{PublisherName="Carturesti",Adress="Iullius Mall, Cluj-Napoca"},
                    new Publisher{PublisherName="Diverta",Adress="Str. Unirii, Cluj-Napoca"},
                    new Publisher{PublisherName="Inmedio",Adress="VIVO Mall, Floresti"},
                    new Publisher{PublisherName="Xpress",Adress="Str. Alexandru Vaida Voievod, Cluj-Napoca"},
                };
                foreach (Publisher p in publishers)
                {
                    context.Publishers.Add(p);
                }
                context.SaveChanges();
                var publishedbooks = new PublishedBook[]
                {
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Norocel" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Bookidz").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Bravo" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Xpress").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Sanatatea ta e importanta" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Carturesti").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "ELLE" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Xpress").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Reteta zilei" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Diverta").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "The One" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Inmedio").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "TVmania" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Xpress").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Men's Health" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Carturesti").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Ziarul financiar" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Inmedio").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Casa mea" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Diverta").ID
                     },
                     new PublishedBook {
                     BookID = books.Single(c => c.Title == "Promotor" ).ID,
                     PublisherID = publishers.Single(i => i.PublisherName == "Carturesti").ID
                     },

                };
                foreach (PublishedBook pb in publishedbooks)
                {
                    context.PublishedBooks.Add(pb);
                }
                context.SaveChanges();
            }
    }
}