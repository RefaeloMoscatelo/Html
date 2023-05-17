using PersonListClientServer.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonListClientServer.Models
{
    public class Person
    {
        [Required]
        public int ID { get; set; }
        [Required]
        //  [StringLength(10)]
        [StringLength(10, ErrorMessage ="גודל עד 10")]
        [ContainAValidation(ErrorMessage ="no a allowed")]
        public string Name { get; set; }
        [Required]
        [Range(20,80)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //[CreditCard]
        //public string creditCard { get; set; }

        public override string ToString()
        {
            return string.Format(Name + " " + Age + " " + Email+" "+ID);
        }
        
       
    }
}