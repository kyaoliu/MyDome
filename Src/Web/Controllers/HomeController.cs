using Repository.AutoFac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var a = new TestModel()
            //{
            //    Age = 11,
            //    Id = 11,
            //    UserName = "ddd"
            //};
            DIContainer.Resolve<Repository.Cached.ICache>().Add("testCached", 11, new TimeSpan(1, 0, 0));
            var entity = DIContainer.Resolve<Repository.Cached.ICache>().Get<int>("testCached");
            var msg = "TestField:" + DIContainer.Resolve<Repository.AutoFac.ITest>().TestField + "<br />";
            msg += "TestField:" + DIContainer.Resolve<Repository.AutoFac.ITest>().TestField + "<br />";
            return Content(msg);
        }
    }
}