using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in array)
            {
                yield return item;
            }
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
        
        public void Remove(T item)
        {
            bool hasBeenRemoved = false;
            bool indexHasBeenPassed = false;
            
            nextArray = new T[Count];
            for(int i = 0; i < Count; i++)
            {
                if (hasBeenRemoved)
                {
                    nextArray[i] = array[i];
                }
                else
                {
                    if(array[i].ToString() == item.ToString())
                    {
                        hasBeenRemoved = true;
                    }
                    else
                    {
                        nextArray[i] = array[i];
                    }
                }
            }
            if (hasBeenRemoved)
            {
                Count--;

                if (Count < 0)
                {
                    Count = 0;
                }
                array = new T[Count];

                for (int i = 0; i < Count + 1; i++)
                {
                    if (nextArray[i] != null && nextArray[i].ToString() != "0")
                    {
                        if (!indexHasBeenPassed)
                        {
                            array[i] = nextArray[i];
                        }
                        else
                        {
                            array[i - 1] = nextArray[i];
                        }
                    }
                    else
                    {
                        indexHasBeenPassed = true;
                    }
                }
            }
            else
            {
                array = nextArray;
            }
        }

        public override string ToString()
        {
            string beginningOfString = "CustomList{ ";
            string endOfString = "}";

            foreach(T item in array)
            {
                beginningOfString += item.ToString() + " ";
            }

            beginningOfString += endOfString;

            return beginningOfString;
        }

        public static CustomList<T> operator +(CustomList<T> first, CustomList<T> second)
        {
            CustomList<T> sum = new CustomList<T>();
            sum = first;
            foreach(T item in second)
            {
                sum.Add(item);
            }
            return sum;
        }
    }
}
