using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using PagedList;
using PagedList.Mvc;


namespace MyBlog.Controllers.Admin
{
    public class YorumAdminController : Controller
    {
        // GET: YorumAdmin
        Context c = new Context();
        [Authorize]
        public ActionResult Index(int p = 1, string ara = "")
        {
            var degerler = c.Yorumlars.OrderByDescending(x => x.ID).Where(x => x.KullaniciAdı.Contains(ara) || ara == null).ToList().ToPagedList(p, 5);
            return View(degerler);
        }
        public ActionResult YorumSil(int id)
        {
            var deger = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumGsayfası(int id)
        {
            var a = c.Yorumlars.Find(id);
            return View("YorumGsayfası", a);
        }
        public ActionResult YorumGuncelle(Yorumlar a)
        {
            var ilt = c.Yorumlars.Find(a.ID);
            ilt.KullaniciAdı = a.KullaniciAdı;
            ilt.Mail = a.Mail ;
            ilt.Yorum = a.Yorum;
            ilt.Tarih = a.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}