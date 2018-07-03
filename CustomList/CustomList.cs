using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList<T>
    {
        T[] array;
        int numberOfSlots;

        public CustomList()
        {
            numberOfSlots = 0;
            array = new T[numberOfSlots];
        }


    }
}
