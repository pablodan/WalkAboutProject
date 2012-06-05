using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using WalkAboutWeb.Models;

namespace WalkAboutWeb.Controllers
{
    public class CategoryController : ApiController
    {
        Repository.CategoryRepository repo = new Repository.CategoryRepository();

        // GET /api/category
        public IEnumerable<Category> Get()
        {
            //if (repo.GetAllCat() == null)
            //{ 
            //   //404
            //}

            return repo.GetAllCat();
        }

        // GET /api/category/5
        public Category  Get(int id)
        {
            return repo.GetByID(id);
        }

        // POST /api/category
        public void Post(Category category)
        {
            repo.AddCategory(category);
        }

        // PUT /api/category/5
        public void Put(Category category)
        {

            repo.UpdateCategory(category);
        }

        // DELETE /api/category/5
        public void Delete(int id)
        {
            repo.DeleteCat(id);
        }
    }
}
