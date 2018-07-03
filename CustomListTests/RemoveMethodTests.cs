using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddThenRemoveOneItemFromList_AccessIndex0_ThrowsException()
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(15);

            myList.Remove(15);

            myList[0] = 0;
        }

        [TestMethod]
        public void AddThenRemoveOneItemFromList_DisplayCount_Returns0()
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(15);

            myList.Remove(15);

            Assert.AreEqual(0, myList.Count);
        }

        [TestMethod]
        public void AddFiveVariablesThenRemoveOneItemFromList_DisplayCount_Returns4()
        {
            CustomList<int> myList = new CustomList<int>();

            for(int i = 0; i < 5; i++)
            {
                myList.Add(i);
            }

            myList.Remove(1);

            Assert.AreEqual(4, myList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddFiveVariablesThenRemoveAllFromList_AccessIndex0_ThrowsException()
        {
            CustomList<int> myList = new CustomList<int>();

            for (int i = 0; i < 5; i++)
            {
                myList.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                myList.Remove(i);
            }

            myList[0] = 0;
        }

        [TestMethod]
        public void RemoveOneItemFromEmptyList_DisplayCount_Returns0()
        {
            CustomList<int> myList = new CustomList<int>();

            myList.Remove(15);

            Assert.AreEqual(0, myList.Count);
        }
    }
}
