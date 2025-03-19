 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdvance
{
    public internal interface IPerson
    {
        string Address { get; set; } 
        void Talk(string message);
        void SetAddress(string address);
    }
}
