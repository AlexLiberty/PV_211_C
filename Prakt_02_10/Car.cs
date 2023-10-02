using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_02_10
{
    internal class Car : IVehicle, IDriveable
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            Console.WriteLine(" Car go!!!");
        }

        public override void Stop()
        {
            Console.WriteLine(" Car stop!!!");
        }

        public void Turn()
        {
            throw new NotImplementedException();
        }
    }
}
