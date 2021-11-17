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
    public class KitapAdminController : Controller
    {
        // GET: KitapAdmin
        Context c = new Context();
        [Authorize]
        public ActionResult Index(int p = 1, string ara = "")
        {
            var degerler = c.Kitaps.OrderByDescending(x => x.ID).Where(x => x.KitapAdi.Contains(ara) || ara == null).ToList().ToPagedList(p, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KitapGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KitapGetir(Kitap id)
        {
            c.Kitaps.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapSil(int id)
        {
            var deger = c.Kitaps.Find(id);
            c.Kitaps.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapGsayfası(int id)
        {
            var a = c.Kitaps.Find(id);
            return View("KitapGsayfası", a);
        }
        public ActionResult KitapGuncelle(Kitap a)
        {
            var ilt = c.Kitaps.Find(a.ID);
            ilt.KitapAdi = a.KitapAdi;
            ilt.İmgKitap = a.İmgKitap;
            ilt.KitapOneren = a.KitapOneren;
            ilt.KitapCikisTarihi = a.KitapCikisTarihi;
            ilt.KitapHakkinda = a.KitapHakkinda;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}