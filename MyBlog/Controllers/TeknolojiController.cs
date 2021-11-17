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
    public class TeknolojiController : Controller
    {
        // GET: Teknoloj
        Context c = new Context();
        public ActionResult Index(int p=1)
        {
            var degerler = c.Bloglars.OrderByDescending(x=>x.ID).Where(x => x.BlogKategori == "Teknoloji").ToList().ToPagedList(p,4);
            return View(degerler);
        }
    }
}