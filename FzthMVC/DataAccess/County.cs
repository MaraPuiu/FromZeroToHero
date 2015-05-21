using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FzthMVC.DataAccess
{
    public class County
    {
        public static int maxId = 1;

        public County()
        {
            Id = maxId;
            maxId++;
        }

        public int Id { get; set; }

        [Display(Name = "County")]
        public string Name { get; set; }
    }
}