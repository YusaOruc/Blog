using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;

namespace MyBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        YetenekHakkimizda yh = new YetenekHakkimizda();
        Context c = new Context();
        public ActionResult Index()
        {
            yh.Hakkimizdas = c.Hakkimizdas.ToList();
            yh.Yeteneks = c.Yeteneks.ToList();
            return View(yh);
        }
    }
}