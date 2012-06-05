using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WalkAboutWeb.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }

        //public string UsId { get; set; }
        public DateTime? DateCreated { get; set; }

        [StringLength(200)]
        public string RouteDescription { get; set; }

        public virtual User User { get; set; }

        //a collection of checkins
        public virtual ICollection<UserRoute> UserRoutes { get; set; }
 

    }

}