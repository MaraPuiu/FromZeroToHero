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

        public IList<Hotel> GetHotels()
        {
            return _session.Query<Hotel>().ToList();
        } 

    }
}