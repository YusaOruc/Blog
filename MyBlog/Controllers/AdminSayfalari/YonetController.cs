using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;

namespace MyBlog.Controllers.AdminSayfalari
{
    public class YonetController : Controller
    {
        // GET: AdminYonet
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Models.Siniflar.Admin a)
        {
            c.Admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AdminSil(int id)
        {
            var deger = c.Admins.Find(id);
            c.Admins.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AdminGetir(int id)
        {
            var a = c.Admins.Find(id);
            return View("AdminGetir", a);
        }
        public ActionResult AdminGuncelle(Models.Siniflar.Admin a)
        {
            var admin = c.Admins.Find(a.ID);
            admin.Kullanici = a.Kullanici;
            admin.Sifre = a.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}