using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WalkAboutWeb.Models
{
    public class WalkAboutDb : DbContext
    {
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Checkin> Checkins { get; set; }
        public DbSet<Discovery> Discoveries { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Route> Routes { get; set; }

        //public WalkAboutDb(string connectionString)
        //    : base("WalkAboutDb")
        //{
        //    Database.SetInitializer<WalkAboutDb>(null);
        //}
        //moved to global.asax
        

    }
}