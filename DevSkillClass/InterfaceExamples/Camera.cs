using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Camera : IProduct
    {
        public double CalculateDiscount()
        {
            throw new NotImplementedException();
        }

        public double CalculateServiceCharge()
        {
            throw new NotImplementedException();
        }
    }
}
