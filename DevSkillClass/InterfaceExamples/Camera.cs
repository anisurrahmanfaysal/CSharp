using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Camera : IProduct , IElectronics
    {
        public string Name { get; set; }

        public double CalculateDiscount()
        {
            throw new NotImplementedException();
        }

        public double CalculateServiceCharge()
        {
            throw new NotImplementedException();
        }

        public double GetDafaultDiscount(int max)
        {
            return 20;
        }

        public void Test()
        {
            
        }
    }
}