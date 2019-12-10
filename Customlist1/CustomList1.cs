using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Customlist1
{
    public class CustomList<T> : IEnumerable
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
        public T this[int index]
        {

            get
            {
                if (index >= 0 && index < count)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();


                }
            }

            set
            {
                if (index >= 0 && index < count)
                {
                    items[index] = value;
                }
                else
                {
                    
                    throw new ArgumentOutOfRangeException();
                }
            }


        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }

        }

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
        public void Remove(T item)
        {
            T[] bucket = new T[count];
            int indexj = 0;
            int countnum = 0;
            int countholder = count;

            for (int i = 0; i < countholder; i++)
            {
                if (item.Equals(items[i]) && countnum == 0)
                {
                    countnum++;
                    count--;
                }
                else
                {
                    bucket[indexj] = items[i];
                    indexj++;
                }

            }



            items = new T[count];
            for (int j = 0; j < count; j++)
            {
                items[j] = bucket[j];
            }


        }
        public override string ToString()
        {
            StringBuilder strings = new StringBuilder();
            string output = "";

            for (int i = 0; i < count; i++)
            {
                output = strings.Append(items[i]) + "";

            }

            return output;

        }

        public static CustomList<T> operator +(CustomList<T> list, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list.Count; i++)
            {
                list3.Add(list[i]);
            }
            for (int j = 0; j < list2.Count; j++)
            {
                list3.Add(list2[j]);
            }
            return list3;
        }
        public static CustomList<T> operator -(CustomList<T> list, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list2.Count; i++)
            {
                list.Remove(list2[i]);
            }
            for (int i = 0; i < list.Count; i++)
            {
                list3.Add(list[i]);
            }
            return list3;
        }
    }
}