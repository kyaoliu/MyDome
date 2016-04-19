using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoFac
{
    public class Testa : ITest
    {
        public string TestField { get; set; }

        public string Method1(int i)
        {
            return "a" + i;
        }

        public string Method2(string str)
        {
            return "a" + str + TestField;
        }
    }
}
