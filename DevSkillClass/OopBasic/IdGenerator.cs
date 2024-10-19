using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasic
{
    public  class IdGenerator
    {
        public string Generate()
        {
            Random random = new Random(DateTime.Now.Microsecond);
            int nextValue = random.Next(300, 900);
            string id = nextValue.ToString();
            return id;
        }
    }
}
