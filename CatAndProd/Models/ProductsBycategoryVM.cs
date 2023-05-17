using CatAndProd.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatAndProd.Models
{
    public class ProductsBycategoryVM  
    {
        public Category category { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AvgPrice { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPagesCount { get; set; }

    }
}