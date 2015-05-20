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
        public ActionResult CheckCreate(string name, string description, string city, string county, int rating)
        {
            Hotel hotel = new Hotel();
            if (ModelState.IsValid)
            {
                int idHotel = Data.MaxId();
                idHotel++;
                hotel = new Hotel
                    {
                        Id = idHotel,
                        Name = name,
                        Description = description,
                        Rating = rating,
                        HotelCity =
                            new City { CityName = city, CityCounty = new County { CountyName = county } }
                    };
                Data.Add(hotel);
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else return View(hotel);
        }

        [HttpPost]
        public ActionResult CheckUpdate(int id, string name, string description, string city, string county, int rating)
        {
            Hotel hotel = new Hotel();
            if (ModelState.IsValid)
            {
                var hotelChanged = Data.FindHotel(id);
                hotelChanged.Name = name;
                hotelChanged.Description = description;
                hotelChanged.Rating = rating;
                hotelChanged.HotelCity.CityName = city;
                hotelChanged.HotelCity.CityCounty.CountyName = county;

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else return View(hotel);
        }
    }
}