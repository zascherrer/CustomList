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
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
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
                if (i < 0 || i >= Count)
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
            count = 0;
            array = new T[Count];
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
            count++;
            T[] nextArray = new T[Count];
            for(int i = 0; i < Count - 1; i++)
            {
                nextArray[i] = array[i];
            }
            nextArray[Count - 1] = item;
            array = nextArray;
        }
        
        public bool Remove(T item)
        {
            bool hasBeenRemoved = false;

            T[] nextArray = new T[Count];
            for (int i = 0; i < Count; i++)
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
                ReplaceArray(nextArray);
            }
            else
            {
                array = nextArray;
            }

            return hasBeenRemoved;
        }

        private void ReplaceArray(T[] nextArray)
        {
            bool indexHasBeenPassed = false;

            count--;

            if (Count < 0)
            {
                count = 0;
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("CustomList{ ");
            string endOfString = "}";

            foreach(T item in array)
            {
                stringBuilder.Append(item.ToString() + " ");
            }

            stringBuilder.Append(endOfString);

            return stringBuilder.ToString();
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

        public static CustomList<T> operator -(CustomList<T> first, CustomList<T> second)
        {
            CustomList<T> result = new CustomList<T>();
            result = first;
            foreach (T item in second)
            {
                result.Remove(item);
            }
            return result;
        }

        public CustomList<T> Zip(CustomList<T> listToZip)
        {
            CustomList<T> result = new CustomList<T>();

            if(Count > listToZip.Count)
            {
                result = ZipArrayGreater(listToZip);
            }
            else if(Count < listToZip.Count)
            {
                result = ZipArrayLess(listToZip);
            }
            else
            {
                result = ZipArrayEqual(listToZip);
            }

            return result;
        }

        private CustomList<T> ZipArrayGreater(CustomList<T> listToZip)
        {
            CustomList<T> result = new CustomList<T>();

            for(int i = 0; i < Count; i++)
            {
                result.Add(array[i]);
                if(i < listToZip.Count)
                {
                    result.Add(listToZip[i]);
                }
            }

            return result;
        }

        private CustomList<T> ZipArrayLess(CustomList<T> listToZip)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < listToZip.Count; i++)
            {
                if (i < Count)
                {
                    result.Add(array[i]);
                }
                result.Add(listToZip[i]);
            }

            return result;
        }

        private CustomList<T> ZipArrayEqual(CustomList<T> listToZip)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < Count; i++)
            {
                result.Add(array[i]);
                result.Add(listToZip[i]);
            }

            return result;
        }

        public void Sort()
        {
            //This method uses Insertion Sort
            int characterIndex = 0;
            InsertionSort(characterIndex);
            

        }

        private void InsertionSort(int characterIndex)
        {
            for (int j = 1; j < Count; j++)
            {
                for (int i = j; i > 0 && array[i].ToString()[characterIndex] <= array[i - 1].ToString()[characterIndex]; i--)
                {
                    Exchange(i, i - 1);

                    if (array[i].ToString().Length > 1 && array[i - 1].ToString().Length > 1)
                    {
                        for (int k = characterIndex + 1; k < array[i].ToString().Length && k < array[i - 1].ToString().Length; k++)
                        {
                            if(array[i].ToString()[k] < array[i - 1].ToString()[k] && array[i].ToString()[characterIndex] == array[i - 1].ToString()[characterIndex])
                            {
                                Exchange(i, i - 1);
                            }
                        }
                    }
                }
            }
        }

        private void Exchange(int one, int two)
        {
            T temporary;

            temporary = array[one];
            array[one] = array[two];
            array[two] = temporary;
        }
    }
}
