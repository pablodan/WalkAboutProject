using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WalkAboutWeb.Models
{
    public class Comment
    {

        [Key]
        public int Id { get; set; }

        public DateTime? CommentDate { get; set; }

        [StringLength(200)]
        public string CommentMsg { get; set; }

        //public byte[] CommentImg { get; set; }

        public string CommImgLocation { get; set; }

        public virtual User User { get; set; }

        public virtual Checkin Checkin { get; set; }

    }
}