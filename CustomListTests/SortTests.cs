using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void ListFourIntsOutOfOrder_Sort_ReturnsOrderedCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myExpectedList = new CustomList<int>();

            myList.Add(40);
            myList.Add(32);
            myList.Add(98);
            myList.Add(1);

            myExpectedList.Add(1);
            myExpectedList.Add(32);
            myExpectedList.Add(40);
            myExpectedList.Add(98);

            myList.Sort();
            
            Assert.AreEqual(myExpectedList[2], myList[2]);
        }

        [TestMethod]
        public void ListFourIntsWithSameFirstDigitOutOfOrder_Sort_ReturnsOrderedCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myExpectedList = new CustomList<int>();

            myList.Add(17);
            myList.Add(15);
            myList.Add(19);
            myList.Add(10);

            myExpectedList.Add(10);
            myExpectedList.Add(15);
            myExpectedList.Add(17);
            myExpectedList.Add(19);

            myList.Sort();

            Assert.AreEqual(myExpectedList[2], myList[2]);
        }
    }
}
