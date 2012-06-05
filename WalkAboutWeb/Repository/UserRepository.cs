using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalkAboutWeb.Models;

namespace WalkAboutWeb.Repository
{
    public class UserRepository
    {
        //readonly Models.WalkAboutDb dc = new Models.WalkAboutDb("WalkAboutDb");

        public IEnumerable<User> GetAll()
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                var AllUsers = (from a in dc.Users
                                select a).ToList();
                return AllUsers;
            }
        }

        // GET /api/user/5
        public  User GetById(string Id)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                var UserByID = (from a in dc.Users
                                where a.UsrId == Id
                                select a);

                return UserByID.First();

                //or
                //return dc.Users.FirstOrDefault(u => u.UsrId == Id);
            }
        }


        // POST
        public void AddUser(User user)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                User usr = new User { 
                 UsrId = user.UsrId ,
                 Fname = user.Fname ,
                 Lname = user.Lname ,
                 CurrentCity = user.CurrentCity 
                
                };

                dc.Users.Add(usr);
                dc.SaveChanges(); 

            }
        }

        //PUT
        public void UpdateUser(User user)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                var CurUser = (from a in dc.Users
                               where a.UsrId == user.UsrId
                               select a).FirstOrDefault();
                CurUser.Fname = user.Fname;
                CurUser.Lname = user.Lname;
                CurUser.CurrentCity = user.CurrentCity;
                dc.SaveChanges();

            }
        }
    }
}