﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPrinciples.OCP
{
    public interface IEncryptionProcess
    {
        string EncryptPassword(string password);
    }
}
