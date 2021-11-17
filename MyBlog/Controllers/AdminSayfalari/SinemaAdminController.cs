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
    
    public class SinemaAdminController : Controller
    {
        
        // GET: SinemaAdmin
        Context c = new Context();

        [Authorize]
        public ActionResult Index(int p = 1, string ara = "")
        {
            var degerler = c.cinemas.OrderByDescending(x => x.ID).Where(x => x.FilmAdi.Contains(ara) || ara == null).ToList().ToPagedList(p, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult SinemaGetir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SinemaGetir(Cinema id)
        {
            c.cinemas.Add(id);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SinemaSil(int id)
        {
            var deger = c.cinemas.Find(id);
            c.cinemas.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SinemaGsayfası(int id)
        {
            var a = c.cinemas.Find(id);
            return View("SinemaGsayfası", a);
        }
        public ActionResult SinemaGuncelle(Cinema b)
        {
            var blg = c.cinemas.Find(b.ID);
            blg.FilmAdi = b.FilmAdi;
            blg.Yonetmen = b.Yonetmen;
            blg.İmgCinema = b.İmgCinema;
            blg.İmgCinema2 = b.İmgCinema2;
            blg.FilmiOneren = b.FilmiOneren;
            blg.FilmCikisTarihi = b.FilmCikisTarihi;
            blg.FilmHakkinda = b.FilmHakkinda;
            blg.FilmKategori = b.FilmKategori;
            blg.DiziorFilm = b.DiziorFilm;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}