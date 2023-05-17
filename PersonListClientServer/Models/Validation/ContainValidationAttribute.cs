using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonListClientServer.Models.Validation
{
    public class ContainAValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString().ToLower().Contains("a"))
            {
                return false;
            }
            return true;
        }
    }
}