using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
    public class UserRoute
    {

        [Key]
        public int Id { get; set; }

        public virtual Route Route { get; set; }

        //a collection of checkins
        public virtual Checkin Checkin { get; set; }
    }
}