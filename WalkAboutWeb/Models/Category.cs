using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
  
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [StringLength(25), Required]
        public string CategoryName { get; set; }


       //note since we will be controlling the category table and will populate it from start, we can 
       //create the icons with unique names and specific sive and simple store them in a folder, 
       //However we will need a more robust way to handle the storage and retrieval of user created images.
        public string IconNameLocal { get; set; }

     
        //public virtual ICollection<Place> Places { get; set; }
    }
}