using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees;
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
            DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
            var hotelEntities = dh.GetHotels().ToList();
            var hotels = Converter.FromEntityToModel(hotelEntities);
            return View(hotels);
        }

        public ActionResult Details(Int32 id)
        {
            DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
            var hotelEntity = dh.GetHotel(id);
            var hotel = Converter.FromEntityToModelOne(hotelEntity);
            if (hotel != null)
            {
                //return Json(hotel, JsonRequestBehavior.AllowGet);
                return View(hotel);
            }
            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(Int32 id)
        {
            DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
            var hotelEntities = dh.GetHotels().ToList();
            var hotels = Converter.FromEntityToModel(hotelEntities);
            foreach (Hotel hotel in hotels)
                if (hotel.Id == id) return View(hotel);
            return RedirectToAction("Index"); 
        }

        public ActionResult Edit(Int32 id)
        {
            DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
            var hotelEntities = dh.GetHotels().ToList();
            var hotels = Converter.FromEntityToModel(hotelEntities);
            foreach (Hotel hotel in hotels)
                if (hotel.Id == id) return View(hotel);
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
                int idHotel = Data.MaxId();
                idHotel++;
                hotel.Id = idHotel;
                var hotelEntity = Converter.FromModelToEntityOne(hotel);
                dh.CreateHotel(hotelEntity);
                return RedirectToAction("Index");
            }
            else return View(hotel);
        }

        [HttpPost]
        public ActionResult Delete(Int32 id, FormCollection toDelete)
        {
            //int idHotel = Convert.ToInt32(toDelete["Id"]);
            DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());

            dh.DeleteHotel(id);
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public ActionResult Edit(Int32 id, Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                DataHelper dh = new DataHelper(NHibernateHelper.OpenSession());
                var hotelChanged = Data.FindHotel(id, Converter.FromEntityToModel(dh.GetHotels().ToList()));
                hotelChanged.Name = hotel.Name;
                hotelChanged.Description = hotel.Description;
                hotelChanged.Rating = hotel.Rating;
                hotelChanged.City.Name = hotel.City.Name;
                hotelChanged.City.County.Name = hotel.City.County.Name;
                var hotelEntity = Converter.FromModelToEntityOne(hotel);
                dh.UpdateHotel(hotelEntity);
                return RedirectToAction("Index"); 
            }
            else return View(hotel);
        }
	}
}