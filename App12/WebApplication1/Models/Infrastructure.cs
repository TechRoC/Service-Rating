using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Infrastructure
    {
        [Key]
        public int Infrastructure_id { get; set; }
        public int Jan_Total { get; set; }
        public int Feb_Total { get; set; }
        public int Mar_Total { get; set; }
        public int Jun_Total { get; set; }
        public int July_Total { get; set; }
       
    }
}