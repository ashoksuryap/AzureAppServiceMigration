using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var fileContents = System.IO.File.ReadAllText(@"C:\Ashok\temp.txt");
            var url = "https://172.22.33.55:8080/api";
            Console.WriteLine(fileContents);
            Console.WriteLine(url);
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
    }
}