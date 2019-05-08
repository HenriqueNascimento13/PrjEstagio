using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Booking.Models;
using Microsoft.AspNetCore.Authorization;
using Booking.Data;

namespace Booking.Controllers
{
    public class HomeController : Controller
    {
        BookingContext db = new BookingContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Book()
        {
            ViewData["Message"] = "Your book page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Index(DateTime? fromDate, DateTime? toDate)
        {
            var listOffers = new List<Ofertas>();
  
            listOffers.Add(new Ofertas() { FromDate = fromDate, ToDate = toDate, HotelName = "Hotel 1", RoomCategory = "Double", Price = 100, PriceBeforeDiscount = 110 });
            listOffers.Add(new Ofertas() { FromDate = fromDate, ToDate = toDate, HotelName = "Hotel 2", RoomCategory = "Single", Price = 120, PriceBeforeDiscount = 125 });
            listOffers.Add(new Ofertas() { FromDate = fromDate, ToDate = toDate, HotelName = "Hotel 3", RoomCategory = "Suite", Price = 240, PriceBeforeDiscount = 255 });
            listOffers.Add(new Ofertas() { FromDate = fromDate, ToDate = toDate, HotelName = "Hotel 4", RoomCategory = "Double", Price = 150, PriceBeforeDiscount = 178 });

            ViewBag.Message = "Wrong password!";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
