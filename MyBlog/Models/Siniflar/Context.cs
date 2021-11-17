using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyBlog.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Bloglar> Bloglars { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Yetenek> Yeteneks { get; set; }

    }
}