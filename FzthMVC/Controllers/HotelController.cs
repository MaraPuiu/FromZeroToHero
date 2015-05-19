using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FZTH.MVC.DataAccess;

namespace FzthMVC.Controllers
{
    public class HotelController : Controller
    {
        //
        // GET: /Hotel/
        [HttpGet]
        public ActionResult Index()
        {
            return View(Data.Hotels);
        }

        public ActionResult Detail(Int32 id)
        {
            var hotel = Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return Json(hotel, JsonRequestBehavior.AllowGet);
            }
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(Int32 id)
        {
            foreach (Hotel hotel in Data.Hotels)
                if (hotel.Id == id) return View(hotel);
            return RedirectToAction("Index"); 
        }

        public ActionResult Edit(Int32 id)
        {
            foreach (Hotel hotel in Data.Hotels)
                if (hotel.Id == id) return View(hotel);
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                int idHotel = Data.MaxId();
                idHotel++;
                hotel.Id = idHotel;
                Data.Add(hotel);
                return RedirectToAction("Index");
            }
            else return View(hotel);
        }

        [HttpPost]
        public ActionResult Delete(Int32 id, FormCollection toDelete)
        {
            //int idHotel = Convert.ToInt32(toDelete["Id"]);
            Data.Remove(id);
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public ActionResult Edit(Int32 id, Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                var hotelChanged = Data.FindHotel(id);
                hotelChanged.Name = hotel.Name;
                hotelChanged.Description = hotel.Description;
                hotelChanged.Rating = hotel.Rating;
                hotelChanged.HotelCity.CityName = hotel.HotelCity.CityName;
                hotelChanged.HotelCity.CityCounty.CountyName = hotel.HotelCity.CityCounty.CountyName;

                return RedirectToAction("Index"); 
            }
            else return View(hotel);
        }
	}
}