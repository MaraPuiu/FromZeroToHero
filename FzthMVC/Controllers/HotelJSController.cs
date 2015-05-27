using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FZTH.MVC.DataAccess;
using System.Net;
using FzthMVC.DataAccess;

namespace FzthMVC.Controllers
{
    public class HotelJSController : Controller
    {
        //
        // GET: /HotelJS/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetHotels()
        {
            return Json(Data.Hotels, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CheckDelete(Int32 id)
        {
            Data.Remove(id);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        public ActionResult CheckCreate(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                int idHotel = Data.MaxId();
                idHotel++;
                hotel = new Hotel
                {
                    Id = idHotel,
                    Name = hotel.Name,
                    Description = hotel.Description,
                    Rating = hotel.Rating,
                    City =
                        new City { Name = hotel.City.Name, County = new County { Name = hotel.City.County.Name } }
                };
                Data.Add(hotel);
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else return View("Error");
        }

        [HttpPost]
        public ActionResult CheckUpdate(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                var hotelChanged = Data.FindHotel(hotel.Id);
                hotelChanged.Name = hotel.Name;
                hotelChanged.Description = hotel.Description;
                hotelChanged.Rating = hotel.Rating;
                hotelChanged.City.Name = hotel.City.Name;
                hotelChanged.City.County.Name = hotel.City.County.Name;

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else return View("Error");
        }
    }
}