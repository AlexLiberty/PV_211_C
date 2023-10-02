using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_02_10
{
    internal interface ICargoCarrier
    {
        void LoadCargo();
        void UnLoadCargo();

    }
}
