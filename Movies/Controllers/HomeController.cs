using Movies.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var arepo = new ActorRepository(new Domain.Entity.MovieContext());
            var actor = arepo.GetActorByActorName("Pradeep Maharathi");
            return Json(new { actor.Name, actor.ActorId }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}