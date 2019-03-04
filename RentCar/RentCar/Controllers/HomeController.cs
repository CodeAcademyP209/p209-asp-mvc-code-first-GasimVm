using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCar.DAL;
using RentCar.Models;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarContext _context;
        public HomeController()
        {
            _context = new CarContext();
        }

        public ActionResult Index()
        {
            return View(_context.Cars);
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
        public ActionResult Create(Cars car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }
            car.Image = "img3.jpeg";
            _context.Cars.Add(car);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}