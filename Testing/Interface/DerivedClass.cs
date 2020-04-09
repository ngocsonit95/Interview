using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Interface
{
    public class DerivedClass : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public string ConCatString(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
