using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using FzthMVC.Entities;

namespace FzthMVC.MapEntities
{
    public class HotelMap:ClassMap<Hotel>
    {
        public HotelMap()
        {
            Table("Hotels");
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Location).Column("LocationId");
        }
    }
}