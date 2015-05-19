using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FzthMVC.DataAccess
{
    public class City
    {
        public static int maxId = 1;

        public City()
        {
            CityId = maxId;
            maxId++;
        }

        public int CityId { get; set; }

        [Display(Name = "City")]
        public string CityName { get; set; }

        private County cityCounty;
        public County CityCounty { 
            get{
                return cityCounty;
            }
            set{
                cityCounty = value;
            }
        }
    }
}