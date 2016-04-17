using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.ModelFirst;

namespace RepositoryTests.ModelFirst
{
    [TestClass]
    public class ModelFirstContextTest
    {
        [TestMethod]
        public void InsertTest()
        {
            using (ModelFirstContextContainer context = new ModelFirstContextContainer())
            {
                var user = new User()
                {
                    Pwd = "",
                    UserName = "",
                    Id = DateTime.Now.Second + DateTime.Now.Millisecond
                };
                context.UserSet.Add(user);

                var count = context.SaveChanges();
                Assert.AreEqual(1, count);
            }
        }
    }
}
