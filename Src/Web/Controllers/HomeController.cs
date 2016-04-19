using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        
            return Content(Repository.AutoFac.DIContainer.Resolve<Repository.AutoFac.ITest>().TestField);
        }
    }
}