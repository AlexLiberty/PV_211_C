﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7_4
{
    internal class President: Worker
    {
        public override void Print()
        {
            Console.WriteLine("Президент!");
        }
    }
}