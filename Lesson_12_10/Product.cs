using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_10
{
    [Serializable]
    internal class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Id { get; set; }
        public int[] ints;
        public Product(string name, float price, int id, int[]ints )
        {   
            Name = name;
            Price = price;
            Id = id;
            this.ints = ints;
        }
        public Product(string name, float price, int id)
        {
            Name = name;
            Price = price;
            Id = id;       
        }
        public override string ToString() 
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (var i in ints)
            //{
            //    sb.Append(i.ToString());
            //}
            //return $"ID: {Id}, Name: {Name}, Price: {Price}, Array: {sb.ToString()}";
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
        }

        

    }
}