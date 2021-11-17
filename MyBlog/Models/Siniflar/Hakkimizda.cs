using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID{ get; set; }
        public string Baslik { get; set; }
        public string Yazi { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
        public string p3 { get; set; }
    }
}