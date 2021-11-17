using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Kitap
    {
        [Key]
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazari { get; set; }
        public string İmgKitap { get; set; }
       
        public string KitapOneren { get; set; }
        public DateTime KitapCikisTarihi { get; set; }
        public string KitapHakkinda { get; set; }
        
    }
}