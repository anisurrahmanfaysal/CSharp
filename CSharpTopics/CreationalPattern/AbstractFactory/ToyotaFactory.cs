using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory
{
    public class ToyotaFactory
    {
        public ToyotaFactory() { 
            EngineFactory engineFactory = new ToyotaEngineFactory();
            HeadLightFactory headLightFactory = new ToyotaHeadLightFactory();
        }
    }
}
