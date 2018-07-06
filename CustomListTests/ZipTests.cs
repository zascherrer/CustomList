using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void AddNoItemsToCustomList_ZipEmptyCustomList_ReturnsEmptyCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ }";
            CustomList<int> actual;

            actual = myList.Zip(myOtherList);

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddItemToCustomList_ZipEmptyCustomList_ReturnsSingleItem()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 17 }";
            CustomList<int> actual;

            myList.Add(17);
            actual = myList.Zip(myOtherList);

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_ZipSingleItemCustomList_ReturnsFourItemsProperlyPlaced()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 0 7 1 2 }";
            CustomList<int> actual;

            for (int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            myOtherList.Add(7);
            actual = myList.Zip(myOtherList);

            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void AddThreeItemsToCustomList_ZipSameThreeItemCustomList_ReturnsSixItemCustomListProperlyPlaced()
        {
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myOtherList = new CustomList<int>();
            string expected = "CustomList{ 0 0 1 1 2 2 }";
            CustomList<int> actual;

            for (int i = 0; i < 3; i++)
            {
                myList.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                myOtherList.Add(i);
            }
            actual = myList.Zip(myOtherList);

            Assert.AreEqual(expected, actual.ToString());

        }
        }
    }
