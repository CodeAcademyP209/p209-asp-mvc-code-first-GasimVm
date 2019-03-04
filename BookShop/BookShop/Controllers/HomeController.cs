using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.DAL;
using BookShop.Models;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookContext _context;

        public HomeController()
        {
            _context = new BookContext();
         
        }

        public ActionResult Index()
        {

            return View(_context.Books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
       
        public ActionResult Create([Bind(Include = "Name, Author,Price,Description")]  Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            book.Image = "img3.jpeg";
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}