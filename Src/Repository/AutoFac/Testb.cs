using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoFac
{
    public class Testb : ITest
    {
        public string TestField { get; set; }
        public string Method1(int i)
        {
            return "b" + i+ TestField;
        }

        public string Method2(string str)
        {
            return "b" + str;
        }
    }
}
