using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using PagedList;
using PagedList.Mvc;
using System.Web.Security;



namespace MyBlog.Controllers.Admin
{
    public class BlogAdminController : Controller
    {
        // GET: BlogAdmin
        Context c = new Context();
        
        [Authorize]
        public ActionResult Index(int p = 1, string ara="")
        {
           
            var degerler = c.Bloglars.OrderByDescending(x => x.ID).Where(x=>x.Baslik.Contains(ara)||ara==null) .ToList().ToPagedList(p, 5);
            return View(degerler);
            
           
        }
        [HttpGet]
        public ActionResult BlogGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogGetir(Bloglar id)
        {
            c.Bloglars.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var deger = c.Bloglars.Find(id);
            c.Bloglars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogrGsayfası(int id)
        {
            var a = c.Bloglars.Find(id);
            return View("BlogrGsayfası", a);
        }
       public ActionResult BlogGuncelle(Bloglar b)
       {
            var blg = c.Bloglars.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.İmgBlog = b.İmgBlog;
            blg.İmgBlog2 = b.İmgBlog2;
            blg.Yazi = b.Yazi;
            blg.Yazi2 = b.Yazi2;
            blg.YazarAdi = b.YazarAdi;
            blg.Tarih = b.Tarih;
            blg.BlogKategori = b.BlogKategori;
            blg.Kaynak = b.Kaynak;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}