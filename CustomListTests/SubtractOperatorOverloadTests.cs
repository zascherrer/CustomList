using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class SubtractOperatorOverloadTests
    {

        [TestMethod]
        public void AddNoItemsToCustomList_SubtractEmptyCustomList_ReturnsEmptyCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ }";
            CustomList<int> actual;
            
            actual = myList - myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddItemToCustomList_SubtractEmptyCustomList_ReturnsSingleItem()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 17 }";
            CustomList<int> actual;

            myList.Add(17);
            actual = myList - myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_SubtractSingleItemCustomList_ReturnsTwoItems()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 0 2 }";
            CustomList<int> actual;

            for (int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            myOtherList.Add(1);
            actual = myList - myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_SubtractSameThreeItemCustomList_ReturnsEmptyCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ }";
            CustomList<int> actual;

            for (int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                myOtherList.Add(i);
            }
            actual = myList - myOtherList;

            Assert.AreEqual(expected, actual.ToString());


        }
    }
}
