using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_MLK
{
    class Modele
    {
        private static connectProjetGSB maConnexion;

        public static void init()
        {
            maConnexion = new connectProjetGSB();
        }
    }
}
