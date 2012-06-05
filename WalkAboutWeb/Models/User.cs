using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
   
   public class User
    {
        [Key]
        public string UsrId { get; set; }

       [StringLength(50)]
       public string Fname { get; set; }

       [StringLength(50)]
        public string Lname { get; set; }

       [StringLength(60)]
        public string CurrentCity { get; set; }
      
    }
}
