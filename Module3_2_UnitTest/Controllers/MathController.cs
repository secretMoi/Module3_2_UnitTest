using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module3_2_UnitTest.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return View();
        }

        public int Carre(int number)
        {
            return number * number;
        } 
    }
}