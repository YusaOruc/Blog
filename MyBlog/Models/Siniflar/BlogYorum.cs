using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBlog.Models.Siniflar;

namespace MyBlog.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Bloglar> BloglarT { get; set; }
        public IEnumerable<Yorumlar> YorumlarT { get; set; }
    }
}