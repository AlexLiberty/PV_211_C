using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C_
{
    internal interface Data
    {
        void Save(Dictionary dictionary);
        void Load(string fileName, ref Dictionary dictionary);
    }
}
