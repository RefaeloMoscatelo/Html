using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Form()
        {
            return View();
        }
        public string Function(int? x, string [] hobbies, int? y)
        {
            //get query string
            //string x = Request.QueryString["x"];
            //string y = Request.QueryString["y"];
            //if (x==null && y==null)
            //{
            //    x = "0";
            //    y = "0";
            //}

            //form post
            //string x = Request.Form["x"];
            //string y = Request.Form["y"];
            //if (x == null && y == null)
            //{
            //    x = "0";
            //    y = "0";
            //}
            //string str = string.Join(", ", hobbies);
            //if (string.IsNullOrEmpty(hobbies.ToString()))
            //{
            string    str = "";
            //}
            return (x * y).ToString() +" "+ str;
//            return (int.Parse(x) + int.Parse(y)).ToString() + " " + Request.Browser.Browser;
          
        }

        public string  PersonDetails(Person p)
        {
            return p.Name + " " + p.Age + " " + string.Join(", ", p.Hobbies) + " " + p.Address.Street;
        }


    }


}