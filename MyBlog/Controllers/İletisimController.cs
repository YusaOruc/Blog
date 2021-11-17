using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;

namespace MyBlog.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }
    }
}