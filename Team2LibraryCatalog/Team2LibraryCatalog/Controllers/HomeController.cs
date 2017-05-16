using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team2Library;

namespace Team2LibraryCatalog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BooksContext context = new BooksContext("BooksContext");
            { 
                context.book.Add(new Books
                {
                   //ID = 0761165827,
                   // Name = "Bacon Nation",
                   // Author = "Peter Kaminsky & Marie Rama",
                   // Description = "125 Irrsistible Recipes",
                   // Location = "Adult library, Cooking",
                   // Checkout = true
                });
                //context.SaveChanges();
            }
            return View();
        }



       [HttpPost]
        public ActionResult Index(string titles)
        {
            using (BooksContext b = new BooksContext("BooksContext"))
            {
                var title = (from t in b.book
                             where t.Name.Contains(titles)
                             select t).ToList();


                if (!title.Any())
                {
                    ViewBag.ErrorMessage = "Book not found in database";
                    return View();
                }
                else
                    return View("BookFound", title);

        }
        }
    }
}
