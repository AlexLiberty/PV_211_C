using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_10_1
{
    internal static class Extension
    {
        //public static bool OdNumber(this int number)
        //{
        //    return number % 2 != 0;
        //}
        public static bool EvNumber(this int number)
        {
            return number % 2 == 0;
        }
    }
}
