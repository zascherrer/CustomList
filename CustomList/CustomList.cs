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
        T[] nextArray;
        public int Count { get; set; }

        public T this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (i >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return array[i];
                }
            }
            set
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (i >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    array[i] = value;
                }
            }
        }

        public CustomList()
        {
            Count = 0;
            array = new T[Count];
            nextArray = new T[Count];
        }

        public void Add(T item)
        {
            Count++;
            nextArray = new T[Count];
            for(int i = 0; i < Count - 1; i++)
            {
                nextArray[i] = array[i];
            }
            nextArray[Count - 1] = item;
            array = nextArray;
        }
        
    }
}
