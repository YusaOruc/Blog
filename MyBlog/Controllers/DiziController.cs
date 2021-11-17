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
    public class DiziController : Controller
    {

        // GET: Dizi
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.cinemas.Where(x => x.DiziorFilm == "Dizi").OrderByDescending(x => x.ID).ToList().ToPagedList(p,6);
            return View(degerler);
        }
        public ActionResult DiziDetay(int id)
        {
            var degerler = c.cinemas.Where(x=>x.ID==id).ToList();
            return View(degerler);
        }
        public ActionResult Kategori(int id)
        {
            if (id == 2)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Drama" && x.DiziorFilm == "Dizi").ToList();
                return View(listele);
                

            }
            else if (id == 3)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Aksiyon" && x.DiziorFilm == "Dizi").ToList();
                return View(listele); 
            }
            else if (id == 4)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Macera" && x.DiziorFilm == "Dizi").ToList();
                return View(listele); 
            }
            else if (id == 5)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Korku" && x.DiziorFilm == "Dizi").ToList();
                
                 return View(listele); 
                
            }
            else if (id == 6)
            {
                var listele = c.cinemas.Where(x => x.FilmKategori == "Komedi" && x.DiziorFilm == "Dizi").ToList();
                return View(listele);
            }
            else
            {
               
                return RedirectToAction("Index");
            }

        }
       

    }
}