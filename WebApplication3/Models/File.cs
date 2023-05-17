using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class FileData
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public DateTime Created { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}