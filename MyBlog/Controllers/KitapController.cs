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
    public class KitapController : Controller
    {
        // GET: Kitap
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.Kitaps.OrderByDescending(x => x.ID).ToList().ToPagedList(p,6);
            return View(degerler);
        }
        public ActionResult KitapDetay(int id)
        {
            var degerler = c.Kitaps.Where(x => x.ID == id).ToList();
            return View(degerler);
        }
    }
}