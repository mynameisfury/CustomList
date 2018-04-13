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
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
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
            if (count == (capacity / 2))
            {
                capacity *= 2;
                array = new T[capacity];
            }
            array[count] = item;
            count++;           
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i] == item)
                {
                    array = new T[capacity];
                }
            }
        }
        public void RemoveAt(int index)
        {

        }

        override public string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                
            }
            return "";
        }

        public CustomList<T> Zip(CustomList<T> ListTwo)
        {
            CustomList<T> thirdList = new CustomList<T>();
            return thirdList;
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

        

        

    }
}
