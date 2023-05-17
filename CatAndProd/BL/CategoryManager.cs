using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatAndProd.BL
{
    public class CategoryManager: IDisposable
    {
        private NorthwindEntities _db;

        public void Dispose()
        {
            _db.Dispose();
        }
        public CategoryManager()
        {
            _db = new NorthwindEntities();
        }
        public List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }
        public Category GetcategoryByID(int ID)
        {
            return _db.Categories.Where(x => x.CategoryID == ID).SingleOrDefault();
        }
    }
}