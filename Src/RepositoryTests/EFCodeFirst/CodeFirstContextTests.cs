using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.EFCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCodeFirst.Tests
{
    [TestClass()]
    public class CodeFirstContextTests
    {
        [TestMethod]
        public void InsertTest()
        {
            using (CodeFirstContext context = new CodeFirstContext())
            {
                var user = new User()
                {
                    CreateIp = "",
                    CreateTime = DateTime.Now,
                    Email = "dddd@qq.com",
                    Modify = DateTime.Now,
                    Other1 = "45334",
                    Pwd = "pwd",
                    UserName = "UserNameddddd",
                    UserType = 2
                };
                var order = new Order()
                {
                    ActualAmount = 111,
                    Amount = 111,
                    OrderList = DateTime.Now.Ticks.ToString(),
                    OrderState = 1,
                    OrderType = 1,
                    PaymentAmount = 111,
                    Remarks = "Remarks",
                    ShopId = "ddd",
                    ShopName = "名字",
                    User = user,
                };

                context.Order.Add(order);
                var count = context.SaveChanges();
                Assert.AreEqual(2, count);
            }
        }
    }
}