using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalkAboutWeb.Models;


namespace WalkAboutWeb.Repository
{
    public class CategoryRepository
    {
        //get all categories
        public  IEnumerable<Category> GetAllCat()
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                var allCategory = (from a in dc.Categories
                                   select a).ToList();

                return allCategory;
            
            }
         
        }

        //get category by ID
        public Category GetByID(int Id)
        { 
              using (WalkAboutDb dc = new WalkAboutDb())
            {
                var CatById = (from c in dc.Categories
                               where c.CatId == Id
                               select c);

                return CatById.First();
            }
        }

        //Post Category
        public void AddCategory(Category category)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                Category cat = new Category
                {

                    CatId = category.CatId,
                    CategoryName = category.CategoryName,
                    IconNameLocal = category.IconNameLocal

                };

                dc.Categories.Add(cat);
                dc.SaveChanges();
            }

        }

        //handles updates
        //Put Category 
        public Category UpdateCategory(Category category)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
               
               //get the current category 

                var CurCat = (from a in dc.Categories
                              where a.CatId == category.CatId
                              select a).FirstOrDefault ();

                //perform update
                CurCat.CategoryName = category.CategoryName;
                CurCat.IconNameLocal = category.IconNameLocal;
                //persist to dbase
                dc.SaveChanges();

                return CurCat;
            }
        
        }

        //Delete category
        public void DeleteCat(int Id)
        {
            using (WalkAboutDb dc = new WalkAboutDb())
            {
                dc.Categories.Remove(dc.Categories.Single<Category>(c => c.CatId == Id));
                //or use a regular Linq query
            }
        }

    }
}