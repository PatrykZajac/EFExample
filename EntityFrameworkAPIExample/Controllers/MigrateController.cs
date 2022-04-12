using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkAPIExample.Model.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkAPIExample.Controllers
{
    [Route("api/migrate")]
    [ApiController]
    public class MigrateController : ControllerBase
    {
        [HttpGet]
        [Route("migrate")]
        public void migrate()
        {
            using (var context = new MyDBContext())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();

            }
        }
        [HttpGet]
        [Route("seed")]
        public void seed()
        {
            using (var context = new MyDBContext())
            {

                var address = new Address()
                {
                    StreetName = "Prosta",
                    City = "Łódź",
                    Country = "Polska",
                    StreetNo = "7a",
                    ZipCode = "92-100"
                };

                var author = new Author()
                {
                    FirstName = "Adam",
                    LastName = "Nowak",
                    BirthDate = new DateTime(1983, 11, 21)
                };


                var department1 = new Department()
                {
                    Name = "Fantasy"
                };

                var book1 = new Book()
                {
                    Name = "Book 1",
                    Department = department1,
                    Author = author
                };
                var department2 = new Department()
                {
                    Name = "Sci-Fi"
                };

                var book2 = new Book()
                {
                    Name = "Book 2",
                    Department = department2,
                    Author = author
                };

                var category1 = new Category()
                {
                    Name = "Powieść"
                };

                var category2 = new Category()
                {
                    Name = "Horror"
                };

                var category3 = new Category()
                {
                    Name = "Komedia"
                };

                var bookToCategory1 = new BookToCategory()
                {
                    Book = book1,
                    Category = category1
                };

                var bookToCategory2 = new BookToCategory()
                {
                    Book = book1,
                    Category = category2
                };

                var bookToCategory3 = new BookToCategory()
                {
                    Book = book2,
                    Category = category1
                };

                var bookToCategory4 = new BookToCategory()
                {
                    Book = book2,
                    Category = category3
                };


                var library = new Library()
                {
                    Address = address,
                    Departments = new List<Department>() { department1, department2 },
                    Name = "Biblioteka Publiczna nr 1"
                };


                context.Books2Categories.Add(bookToCategory1);
                context.Books2Categories.Add(bookToCategory2);
                context.Books2Categories.Add(bookToCategory3);
                context.Books2Categories.Add(bookToCategory4);
                context.Libraries.Add(library);
                context.SaveChanges();

            }
        }
    }
}
