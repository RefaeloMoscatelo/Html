using CatAndProd.BL;
using CatAndProd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatAndProd.Controllers
{
    public class CategoryController : Controller
    {
        private const int PAGE_SIZE = 3;

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategories()
        {
            using (CategoryManager cm = new CategoryManager())
            {
                return View(cm.GetAll());
            }
        }
        public ActionResult Products(int ID, int page=1)
        {
            using (ProductManager pm = new ProductManager())
            {
                using (CategoryManager cm = new CategoryManager())
                {
                    var totalProducts = pm.GetCountByCategoryID(ID);
                    var category = cm.GetcategoryByID(ID);
                    var products = pm.getProductsbyCaTID(ID,(page-1),PAGE_SIZE);

                    ProductsBycategoryVM vm = new ProductsBycategoryVM()
                    {
                        TotalPagesCount = (int)Math.Ceiling((double)totalProducts / PAGE_SIZE),
                        CurrentPage = page,
                        Products = products,
                        category = category,
                        TotalPrice = products.Sum(x => x.UnitPrice).GetValueOrDefault(),
                        AvgPrice = products.Average(x => x.UnitPrice).GetValueOrDefault()
                    };
                    return View(vm);
                }

              
            }

        }
    }
}