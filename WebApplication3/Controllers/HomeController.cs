using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Files()
        {
            DirectoryInfo files = new DirectoryInfo(@"C:\Users\Rafael\Desktop\");

            var list = files.GetFiles().Select(x => new FileData
            {
                FileName = x.FullName,
                Extension = x.Extension,
                Size = (int)x.Length,
                ModifiedOn = x.LastWriteTime
               
            }).ToArray();

           // ViewData["files"] = list;
            //  return View(list);
            return View(list);
        }



        public ActionResult Mytime()
        {

            string[] names = { "aaa", "bbb", "ccc" };
            ViewData["names"] = names;
           // return ViewData["names"];

            return View();
            // return "<p style='color:red' >unpa</p>"+ DateTime.Now.ToLongDateString();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}