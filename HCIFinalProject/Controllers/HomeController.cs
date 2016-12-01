using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HCIFinalProject.Models;
using System.Web.SessionState;

namespace HCIFinalProject.Controllers
{

    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Families()
        {
            ViewBag.Message = "The Family Collection";

            return View();
        }

        public ActionResult People()
        {
            ViewBag.Message = "Every Person in the System";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "Every Person in the System";

            return View();
        }
    }
}