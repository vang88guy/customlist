using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlist1
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
        public int Capacity { get { return capacity; } }
        public T this[int index] { get { return items[index]; } set { items[index] = value; } }
        public void Add(T item)
        {

            if (count == capacity)
            {
                capacity *= 2;
            }
            T[] bucket = new T[count];
            for (int i = 0; i < count; i++)
            {
                bucket[i] = items[i];
            }
            items = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                items[i] = bucket[i];
            }
            items[count] = item;
            count++;
        }

    }
}