using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_05_10
{
    internal class Play
    {
        private string _name { get; set; }
        private string _nameplay { get; set; }
        private string _genre { get; set; }
        private int _year { get; set; }

        public Play(string name,string nameplay,string genre, int year)
           {
            _name=name; 
            _nameplay=nameplay;
            _genre=genre;
            if(year>0) _year=year;
            else _year=0;
           }
        public void Print()
        {
            Console.WriteLine(_name+"\t" +_nameplay + "\t" + _genre + "\t" + _year);
        }
        ~Play()
        {
            Console.WriteLine($" Finalize: { _nameplay}");
            Console.Beep();
        }


    }
}
