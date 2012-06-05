using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
   
    public class Place
    {
        [Key]
        public int PlcId { get; set; }

        [Required]
        public decimal Lattitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        public DateTime DateJoined { get; set; }


        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Discovery> Discoveries { get; set; } 
    }
}
