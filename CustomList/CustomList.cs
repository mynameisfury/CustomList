using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] array;
        int capacity;

        public CustomList()
        {
            capacity = 5;
            array = new T[capacity];
        }
        public void Add()
        {

        }
        public void Remove()
        {

        }

        override public string ToString()
        {
            return "string";
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
