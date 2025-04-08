﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory
{
    public class NissanHeadLishtFactory : HeadLightFactory
    {
        public override HeadLight CreateHeadLight()
        {
            return new NissanHeadLight();
        }
    }
}
