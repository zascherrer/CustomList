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
        int numberOfSlots;

        public T this[int i]
        {
            get { return array[i]; }
            set
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (i > numberOfSlots)
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
            numberOfSlots = 0;
            array = new T[numberOfSlots];
            nextArray = new T[numberOfSlots];
        }

        public void Add(T item)
        {
            numberOfSlots++;
            nextArray = new T[numberOfSlots];
            for(int i = 0; i < numberOfSlots - 1; i++)
            {
                nextArray[i] = array[i];
            }
            nextArray[numberOfSlots - 1] = item;
            array = nextArray;
        }

    }
}
