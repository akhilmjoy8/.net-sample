using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        LoginRepository LogRepo;
        public HomeController()
        {
            LogRepo = new LoginRepository();
        }
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

        public ActionResult Register(int? isreg)
        {
            return View();

        }
        [HttpPost]
        public ActionResult Register(tbl_Login model)
        {
            LogRepo.Register(model);
            return RedirectToAction("Register",new { isreg = 1});
        }
        public ActionResult Details()
        {
            List<tbl_Login> model = new List<tbl_Login>();
            model = LogRepo.GetDetails();
            return View(model);
        }
    }
}