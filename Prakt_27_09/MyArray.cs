using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_27_09
{
    internal class MyArray<T>
    {
        private int size;
        private T[] arr;
        public MyArray(int size)
        {
            this.size = size;
            arr = new T[size];
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public T[] Items
        {
            get { return arr; }
            set { arr = value; }
        }
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public static MyArray<T> operator +(MyArray<T> m1, MyArray<T> m2)
        {
            if (m1.Size != m2.Size)
                throw new ArgumentException("Розмір масивів має бути однаковим.");

            MyArray<T> result = new MyArray<T>(m1.Size);

            for (int i = 0; i < m1.Size; i++)
            {
                result[i] = (dynamic)m1[i] + (dynamic)m2[i];//важливо!!! без dynamic не працює
            }
            return result;
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(this[i]);
                if (i < Size - 1)
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
   
}
