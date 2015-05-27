using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FzthMVC.Entities;
using NHibernate;
using NHibernate.Linq;

namespace FzthMVC
{
    public class DataHelper
    {
        private readonly ISession _session;

        public DataHelper(ISession session)
        {
            _session = session;
        }

        public IQueryable<Hotel> GetHotels()
        {
            return _session.Query<Hotel>();
        }

        public void CreateHotel(Hotel hotel)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.Save(hotel);

                transaction.Commit();
            }
        }

        public void DeleteHotel(int id)
        {
            using (_session)
            {
                using (ITransaction transaction = _session.BeginTransaction())
                {
                    var hotel = _session.Get<Hotel>(id);
                    _session.Delete(hotel);

                    transaction.Commit();
                }
            }
        }

        public void UpdateHotel(Hotel hotel)
        {
            using (_session)
            {
                using (ITransaction transaction = _session.BeginTransaction())
                {

                    var hotelToUpdate = _session.Get<Hotel>(hotel.Id);

                    hotelToUpdate.Name = hotel.Name;
                    hotelToUpdate.Location.City = hotel.Location.City;
                    hotelToUpdate.Location.County = hotel.Location.County;
                    _session.Update(hotelToUpdate);

                    transaction.Commit();
                }
            }
        }

        public Hotel GetHotel(int id)
        {
            return _session.Get<Hotel>(id);
        } 

    }
}