using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string [] Hobbies { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
    }
}