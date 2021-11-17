using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string mapLink { get; set; }
    }
}