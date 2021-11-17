using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogYorum by = new BlogYorum();
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.Bloglars.Where(x => x.BlogKategori == "Blog").OrderByDescending(x=>x.ID).ToList().ToPagedList(p,4);

            return View(degerler);
        }
        public PartialViewResult AramaBari()
        {
            var degerler = c.Bloglars.Take(5).OrderByDescending(x => x.ID).ToList();
            
            return PartialView(degerler);
        }
        public ActionResult BlogDetay(int id)
        {
            //var degerler = c.Bloglars.Where(x => x.ID == id ).ToList();
            by.BloglarT = c.Bloglars.Where(x => x.ID == id).ToList();
            by.YorumlarT = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            ViewBag.YorumSayisi = c.Yorumlars.Where(x => x.Blogid ==id).Count();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult Yorumlar(int id)
        {
            ViewBag.ID = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Yorumlar(Yorumlar y)
        {
            ViewBag.ID = y.Blogid;
            c.Yorumlars.Add(y);
            c.SaveChanges();

            return PartialView();
        }
    }
}