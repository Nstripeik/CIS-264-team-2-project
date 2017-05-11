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
                //context.book.Add(new Books
                //{
                //    ID = 1,
                //    Name = "Pro ASP.NET MVC 5",
                //    Author = "Adam Freeman",
                //    Description = "build the most maintainable standards-complaint, and best performing web applications on the microsoft platform",
                //    Location = "Adult library, programing section",
                //    Checkout = true
                //});
                //context.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}