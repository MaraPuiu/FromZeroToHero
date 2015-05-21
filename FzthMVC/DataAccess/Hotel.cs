using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FzthMVC.DataAccess;

namespace FZTH.MVC.DataAccess
{
    public class Hotel
    {
        public Int32 Id { get; set; }

        [Required]
        [StringLength(30)]
        public String Name { get; set; }

        [Required]
        [StringLength(30)]
        public String Description { get; set; }

        public City City { get; set; }

        [Required]
        [Range(1, 10)]
        public Int32 Rating { get; set; }
    }
}