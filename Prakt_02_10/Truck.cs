﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_02_10
{
    internal class Truck : IVehicle, IDriveable, ICargoCarrier
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void LoadCargo()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public void Turn()
        {
            throw new NotImplementedException();
        }

        public void UnLoadCargo()
        {
            throw new NotImplementedException();
        }
    }
}
