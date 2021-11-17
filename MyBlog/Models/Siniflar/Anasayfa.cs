using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Anasayfa
    {
        public int ID { get; set; }
        public string Baslik{ get; set; }
        public string Yazi { get; set; }
        public string İmgAnasayfa { get; set; }
        public string AnasayfaKategori { get; set; }
    }
}