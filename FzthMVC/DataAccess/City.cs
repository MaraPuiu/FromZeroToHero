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
            Id = maxId;
            maxId++;
        }

        public int Id { get; set; }

        [Display(Name = "City")]
        public string Name { get; set; }

        private County county;
        public County County { 
            get{
                return county;
            }
            set{
                county = value;
            }
        }
    }
}