using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{


   public class Checkin
    {
         [Key]
        public int ChkId { get; set; }

        public DateTime CheckinDate { get; set; }
   
        public virtual  Place Place { get; set;  }

        public virtual ICollection<Discovery> Discoveries { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual User User { get; set; }

 
        
     
    }
}
