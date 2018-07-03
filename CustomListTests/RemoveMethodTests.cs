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
    }
}
