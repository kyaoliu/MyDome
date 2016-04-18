using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            var model = new Models.TestModel()
            {
                Age = 11,
                Id = 111,
                UserName = "ddddd"
            };
            return Json(model);
        }

        //public Models.TestModel Get(int id)
        //{
        //    var model = new Models.TestModel()
        //    {
        //        Age = 11,
        //        Id = id,
        //        UserName = "ddddd"
        //    };

        //    return model;
        //}

        public Models.TestModel Get(int id,string name)
        {
            var model = new Models.TestModel()
            {
                Age = 11,
                Id = id,
                UserName = name
            };

            return model;
        }
        [HttpGet]
        public Models.TestModel Test(int id)
        {
            var model = new Models.TestModel()
            {
                Age = 11,
                Id = id,
                UserName = "Test"
            };

            return model;
        }
    }
}
