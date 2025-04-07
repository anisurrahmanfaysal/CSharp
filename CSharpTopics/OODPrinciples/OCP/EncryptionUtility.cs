using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OODPrinciples.OCP
{
    public class MD5EncryptionUtility : IEncryptionProcess
    {
        private const string _encryptionHash = "Nothing happend!";

        public string EncryptPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
