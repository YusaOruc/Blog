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
    public class FilmController : Controller
    {
        // GET: Film
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.cinemas.Where(x => x.DiziorFilm == "Film").OrderByDescending(x => x.ID).ToList().ToPagedList(p,6);
            return View(degerler);
        }
        public ActionResult FilmDetay(int id)
        {
            var degerler = c.cinemas.Where(x => x.ID == id).ToList();
            return View(degerler);
        }
        public ActionResult FilmKategori(int id)
        {
            if (id == 2)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Drama" && x.DiziorFilm=="Film").ToList();
                return View(listele);


            }
            else if (id == 3)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Aksiyon" && x.DiziorFilm == "Film").ToList();
                return View(listele);
            }
            else if (id == 4)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Macera" && x.DiziorFilm == "Film").ToList();
                return View(listele);
            }
            else if (id == 5)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Korku" && x.DiziorFilm == "Film").ToList();

                return View(listele);

            }
            else if (id == 6)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Komedi" && x.DiziorFilm == "Film").ToList();
                return View(listele);
            }
            else
            {

                return RedirectToAction("Index");
            }

        }

    }
}