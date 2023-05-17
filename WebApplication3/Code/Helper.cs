using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication3.Code
{
    public static class Helper
    {
        public static List<Color> GetColors()
        {
            var colors = typeof(Color)
                .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Select(x => (Color)x.GetValue(null));

            return colors.ToList();
        }




    }
}