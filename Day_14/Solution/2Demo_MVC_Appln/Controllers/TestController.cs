using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2Demo_MVC_Appln.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //http://localhost:57188/Test/Show
        // TO RUN WE HAVE TO PASS THE CLASS NAME AND METHOD NAME
        public ActionResult Show()
        {
            return View("XYZ");
        }
    }
}