using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C_
{
    internal class Translation
    {
        public string Word { get; set; }
        public List<string> Translations { get; set; }

        public Translation(string word, List<string> translations)
        {
            Word = word;
            Translations = translations;
        }
    }
}
