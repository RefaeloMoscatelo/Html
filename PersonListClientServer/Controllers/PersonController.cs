using PersonListClientServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonListClientServer.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public string SendPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                return p.ToString();
            }
            else
            {
                var q = ModelState.Where(x => x.Value.Errors.Any())
                  .Select(x => x.Value.Errors[0].ErrorMessage).ToArray();
                return string.Join("</br>", q.ToArray());
            }

           
        }
        public string SendPeople(Person[] p)
        {
            List<Person> list = new List<Person>()
            {
              new Person {Age = 12, Name = "David", Email = "David@gmail.com",ID=12},
              new Person {Age = 23, Name = "Naama", Email = "Naama@gmail.com",ID=11114},
              new Person {Age = 33, Name = "Ron", Email = "Roni@gmail.com",ID=4},
               new Person {Age = 42, Name = "Dr", Email = "Drorgmail.co.il",ID=6},
                new Person {Age = 18, Name = "Keren", Email = "Keren@gmail.com",ID=3},
            };

            var z = list.Select(x => x.Name).ToArray();

            // return string.Join("</br>", list.Select(x => x.ToString()));
            if (ModelState.IsValid)
            {
                return string.Join("</br>",
                list.Select(x => x.ToString()).ToArray());
            }
            else
            {
                return "error";
            }

            
        }
    }
}