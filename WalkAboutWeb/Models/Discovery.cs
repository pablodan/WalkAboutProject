using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
  
   public class Discovery
    {
        [Key]
       public int DisId { get; set; }

       [StringLength(25)]
        public int Title { get; set; }

       [StringLength(200)]
        public string Description { get; set; }

        public string ThumbnailName { get; set; }

        public byte[] Thumbnail { get; set;  }
  
        public DateTime DateCreated { get; set; }

        public virtual Place Place { get; set; }
      
    }
}
