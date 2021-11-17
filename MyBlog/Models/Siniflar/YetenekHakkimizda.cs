using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class YetenekHakkimizda
    {
        public IEnumerable<Yetenek> Yeteneks { get; set; }
        public IEnumerable<Hakkimizda> Hakkimizdas { get; set; }
    }
}