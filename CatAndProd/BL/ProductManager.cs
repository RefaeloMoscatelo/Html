using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatAndProd.BL
{
    public class ProductManager : IDisposable
    {
        private NorthwindEntities _db;
        public void Dispose()
        {
            _db.Dispose();
        }
        public ProductManager()
        {
            _db = new NorthwindEntities();
        }
        public List<Product> getProductsbyCaTID(int CATid,int skip, int take)
        {
          return  _db.Products.Where(x => x.CategoryID == CATid)
                .OrderBy(x=>x.ProductID)
                .Skip(skip)
                .Take(take)
                .ToList();

        }

        public int GetCountByCategoryID(int catID)
        {
            return _db.Products.Count(x => x.CategoryID == catID);
        }
    }
}