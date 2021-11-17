using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models.Siniflar;

namespace MyBlog.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Yazars.ToList();
            return View(degerler); 
        }
    }
}