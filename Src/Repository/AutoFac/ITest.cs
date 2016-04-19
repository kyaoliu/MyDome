using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoFac
{
    public interface ITest
    {
        string TestField { get; set; }
        string Method1(int i);
        string Method2(string str);
    }
}
