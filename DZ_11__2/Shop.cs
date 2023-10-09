using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_2
{
    internal class Shop
    {
        public string Name {  get; set; }
        public string Type {  get; set; }
        public string Adress {  get; set; }
        public Shop(string name,string type,string adress) 
        {
            Name = name;
            Type = type;
            Adress = adress;
        }

    }
}
