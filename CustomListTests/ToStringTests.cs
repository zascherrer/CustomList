using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void EmptyCustomList_ToString_ReturnsEmptyCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            string expected = "CustomList{ }";
            string actual;

            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleItemCustomList_ToString_ReturnsSingleItemCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            string expected = "CustomList{ 42 }";
            string actual;

            myList.Add(42);
            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenItemCustomList_ToString_ReturnsTenItemCustomList()
        {
            CustomList<int> myList = new CustomList<int>();
            string expected = "CustomList{ 0 1 2 3 4 5 6 7 8 9 }";
            string actual;

            for(int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
