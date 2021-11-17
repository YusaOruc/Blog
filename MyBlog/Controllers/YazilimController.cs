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
    public class YazilimController : Controller
    {
        // GET: Yazilim
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.Bloglars.OrderByDescending(x=>x.ID).Where(x => x.BlogKategori == "Yazilim").ToList().ToPagedList(p, 4);
            return View(degerler);
        }
    }
}