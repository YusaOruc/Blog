using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;

namespace MyBlog.Controllers
{
    
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
           
        }
        public PartialViewResult serviceSection()
        {
            return PartialView();
        }
        public PartialViewResult features()
        {
            var degerler = c.Bloglars.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult film()
        {
            var degerler = c.cinemas.Where(x => x.DiziorFilm == "Film").OrderByDescending(x=>x.ID).Take(4).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Kitap()
        {
            var degerler = c.Kitaps.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(degerler);
        }




    }
}