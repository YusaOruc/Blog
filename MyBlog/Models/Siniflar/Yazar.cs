using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Yazar
    {
        [Key]
        public int ID { get; set; }
        public string AdiSoyadi { get; set; }
        public string Meslegi { get; set; }
        public string Mail { get; set; }
        public string Hakkinda { get; set; }
      
    }
}