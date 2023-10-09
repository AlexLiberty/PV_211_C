using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_3
{
    internal class Kafe : IEnumerable<Workers>
    {
        private List<Workers> _workers;
        public Kafe() 
        {
            _workers = new List<Workers>();
        }
        public void AddWorker(string name, int age, string position)
        {
            Workers worker=new Workers(name, age, position);    
            _workers.Add(worker);
        }
        public IEnumerator<Workers>GetEnumerator()
        { 
            return _workers.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() 
        {
            return GetEnumerator();
        }
    }
}
