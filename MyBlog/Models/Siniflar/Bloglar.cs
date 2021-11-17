using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Bloglar
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string İmgBlog { get; set; }
        public string Yazi { get; set; }
        public string İmgBlog2 { get; set; }
        public string Yazi2 { get; set; }

        public string YazarAdi { get; set; }
        public DateTime Tarih { get; set; }
        public int like { get; set; }
        public string BlogKategori { get; set; }
        public string Kaynak { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

        
        
    }
}