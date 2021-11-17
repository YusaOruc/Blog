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
    public class YazarAdminController : Controller
    {
        // GET: YazarAdmin
        Context c = new Context();
        [Authorize]
        public ActionResult Index(int p=1,string ara="")
        {
            var degerler = c.Yazars.OrderByDescending(x => x.ID).Where(x => x.AdiSoyadi.Contains(ara) || ara == null).ToList().ToPagedList(p, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YazarGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YazarGetir(Yazar id)
        {
            c.Yazars.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarSil(int id)
        {
            var deger = c.Yazars.Find(id);
            c.Yazars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarGsayfası(int id)
        {
            var a = c.Yazars.Find(id);
            return View("YazarGsayfası", a);
        }
        public ActionResult YazarGuncelle(Yazar a)
        {
            var ilt = c.Yazars.Find(a.ID);
            ilt.AdiSoyadi = a.AdiSoyadi;
            ilt.Meslegi = a.Meslegi;
            ilt.Mail = a.Mail;
            ilt.Hakkinda = a.Hakkinda;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}