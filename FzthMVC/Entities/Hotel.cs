using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FzthMVC.Entities
{
    public class Hotel
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual Location Location { get; set; }
    }
}