using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_02_10
{
    internal abstract class IVehicle
    {
        private int speed;
        private int fuellevel;
        public abstract void Start();
        public abstract void Stop();

        public int Speed { get; set; }
        public int Fuellevel { get; set; }
    }
}