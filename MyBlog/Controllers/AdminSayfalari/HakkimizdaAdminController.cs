using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using System.Web.Security;

namespace MyBlog.Controllers.Admin
{
    public class HakkimizdaAdminController : Controller
    {
        // GET: Hakk
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult HakkimizdaGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HakkimizdaGetir(Hakkimizda id)
        {
            c.Hakkimizdas.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult HakkimizdaSil(int id)
        {
            var deger = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult HakkimizdaGsayfası(int id)
        {
            var a = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGsayfası", a);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda a)
        {
            var ilt = c.Hakkimizdas.Find(a.ID);
            ilt.Baslik = a.Baslik;
            ilt.Yazi = a.Yazi;
            ilt.p1 = a.p1;
            ilt.p2 = a.p2;
            ilt.p3 = a.p3;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}