using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;
using System.Web.Security;


namespace MyBlog.Controllers.Admin
{
    public class iletisimAdminController : Controller
    {
        // GET: İletisimAdmin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult iletisimGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult iletisimGetir(iletisim id)
        {
            c.iletisims.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult iletisimSil(int id)
        {
            var deger = c.iletisims.Find(id);
            c.iletisims.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult iletisimGsayfası(int id)
        {
            var a = c.iletisims.Find(id);
            return View("iletisimGsayfası", a);
        }
        public ActionResult iletisimGuncelle(iletisim a)
        {
            var ilt = c.iletisims.Find(a.ID);
            ilt.Adres = a.Adres;
            ilt.Mail = a.Mail;
            ilt.Telefon = a.Telefon;
            ilt.mapLink = a.mapLink;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}