using MonoTestUciliste.Service.DAL;
using MonoTestUciliste.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonoTestUciliste.MVC.Controllers
{
    public class HomeController : Controller
    {
        private EFStudentContext db = new EFStudentContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<PregledDatumaUpisa> data = from student in db.Studenti
                                                  group student by student.DatumUpisa into dateGroup
                                                  select new PregledDatumaUpisa()
                                                  {
                                                      DatumUpisa = dateGroup.Key,
                                                      BrojStudenata = dateGroup.Count()
                                                  };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}