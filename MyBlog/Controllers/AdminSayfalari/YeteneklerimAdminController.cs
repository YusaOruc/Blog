using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace MyBlog.Controllers.AdminSayfalari
{
    public class YeteneklerimAdminController : Controller
    {
        // GET: YeteneklerimAdmin
        Context c = new Context();
        [Authorize]
        public ActionResult Index(int p = 1, string ara = "")
        {
            var degerler = c.Yeteneks.OrderByDescending(x => x.ID).Where(x => x.YetenekAdi.Contains(ara) || ara == null).ToList().ToPagedList(p, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YetenekGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenek id)
        {
            c.Yeteneks.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var deger = c.Yeteneks.Find(id);
            c.Yeteneks.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YetenekGsayfası(int id)
        {
            var a = c.Yeteneks.Find(id);
            return View("YetenekGsayfası", a);
        }
        public ActionResult YetenekGuncelle(Yetenek a)
        {
            var ilt = c.Yeteneks.Find(a.ID);
            ilt.YetenekAdi = a.YetenekAdi;
            ilt.Yuzdesi = a.Yuzdesi;
           
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}