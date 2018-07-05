using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        [TestMethod]
        public void AddItemToCustomList_AddEmptyCustomList_ReturnsSingleItem()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 17 }";
            CustomList<int> actual;

            myList.Add(17);
            actual = myList + myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddItemToCustomList_AddSingleItemCustomList_ReturnsTwoItems()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 17 99 }";
            CustomList<int> actual;

            myList.Add(17);
            myOtherList.Add(99);
            actual = myList + myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_AddSingleItemCustomList_ReturnsFourItems()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 0 1 2 99 }";
            CustomList<int> actual;

            for(int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            myOtherList.Add(99);
            actual = myList + myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_AddThreeItemCustomList_ReturnsSixItems()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 0 1 2 0 1 2 }";
            CustomList<int> actual;

            for (int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            for(int i = 0; i < 3; i++)
            {
                myOtherList.Add(i);
            }
            actual = myList + myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }
    }
}
