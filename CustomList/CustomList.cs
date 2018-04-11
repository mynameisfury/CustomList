using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        public T[] array;
        int capacity;
        private int count;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public CustomList()
        {
            capacity = 5;
            array = new T[capacity];
        }
        public void Add(T item)
        {
            


        }
        public void Remove(T item)
        {

        }

        override public string ToString()
        {
            return "string";
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //iteration

        //plus
        //public static Complex operator+()
        //    {

        //    }

        //minus

        //zipping

        //count

        

    }
}
