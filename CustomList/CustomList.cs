using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
     public class CustomList<T>
    {
        T[] items;
        int count;
        int capacity;
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        public int Count { get { return count; } }
        public void CountItems()
        {
            foreach (object item in items)
            {
                count++;
            }
        }
        public T this[int index] { get { return items[index]; } set {items[index] = value;} }
        public void AddTo() 
           { 
            
           }

    }
}
