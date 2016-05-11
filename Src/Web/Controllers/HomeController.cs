using Repository.AutoFac;
using Repository.Filter.PageTokenView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Repository.Filter.Class1]
        public ActionResult Index()
        {
            return View();
            //var a = new TestModel()
            //{
            //    Age = 11,
            //    Id = 11,
            //    UserName = "ddd"
            //};


            //var n = 4;
            //var arr = new bool[n, n];
            //for (int y = 0; y < n; y++)
            //{
            //    var x = y % 2 == 0 ? 0 : 3;
            //    arr[y, x] = true;
            //}


            //var n = 4;
            //var arr = new bool[n, n];

            //int x = 0, y = 0;
            //do
            //{
            //    arr[++y, x += 2] = true;
            //} while (x + 2 < n);

            //while ((x - 2) > 0)
            //{
            //    arr[++y, x -= 2] = true;
            //}

            //if (n % 2 == 0)
            //{
            //    arr[++y, 2] = true;
            //}

            /*
             把棋盘看成一个N*N的坐标(x,y); 
             y轴加1,x轴加2                          棋子(y,x+=2)
             当y轴大于N/2 && x不等于0时 x轴减等于2  棋子(y,x-=2)
             */
            //var n = 4;
            //var x = 0;
            //var arr = new bool[n, n];
            //for (var y = 0; y < n; y++)
            //{
            //    x = y > (n / 2d) && x > 0 ? x - 2 : x + 2;
            //    arr[y, x] = true;
            //}


            DIContainer.Resolve<Repository.Cached.ICache>().Add("testCached", 11, new TimeSpan(1, 0, 0));
            var entity = DIContainer.Resolve<Repository.Cached.ICache>().Get<int>("testCached");
            var msg = "TestField:" + DIContainer.Resolve<Repository.AutoFac.ITest>().TestField + "<br />";
            msg += "TestField:" + DIContainer.Resolve<Repository.AutoFac.ITest>().TestField + "<br />";
            //  return Content(msg);
        }


        [ValidateReHttpPostToken]
        public ActionResult TestPageToken()
        {
            return Content("123");
        }
    }
}