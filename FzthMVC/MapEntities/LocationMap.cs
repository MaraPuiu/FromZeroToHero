using FzthMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using NHibernate;

namespace FzthMVC.MapEntities
{
    public class LocationMap:ClassMap<Location>
    {
        public LocationMap()
        {
            Table("Locations");
            Id(x => x.Id);
            Map(x => x.City);
            Map(x => x.County);
            HasMany(x => x.Hotels).KeyColumn("LocationId");
        }
    }
}