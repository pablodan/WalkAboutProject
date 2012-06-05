using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using WalkAboutWeb.Models;

namespace WalkAboutWeb.Controllers
{
    public class UserController : ApiController
    {
        Repository.UserRepository repo = new Repository.UserRepository();

        // GET /api/user
        public IEnumerable<User> Get()
        {
            if (repo.GetAll() == null)
            { 
                //return 404
            }
           return repo.GetAll();
        }

        // GET /api/user/5
        public User Get(string id)
        {
            return repo.GetById(id);

        }

        // POST /api/user
        public void Post(User user)
        {

            repo.AddUser(user);
        }

        // PUT /api/user/5
        public void Put(User user)
        {
            repo.UpdateUser(user);
        }

        // DELETE /api/user/5
        //public void Delete(int id)
        //{
        //}
    }
}
