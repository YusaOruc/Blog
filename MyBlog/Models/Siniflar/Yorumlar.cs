using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdı { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public DateTime Tarih { get; set; }
        public int Blogid { get; set; }
        public int Bloglar_ID { get; set; }
        public Bloglar Blog { get; set; }


    }
}