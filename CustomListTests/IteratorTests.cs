using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        public void AddItemToCustomList_IterateThroughCustomList_ReturnsItemAdded()
        {
            CustomList<int> myList = new CustomList<int>();

            myList.Add(15);

            foreach(int item in myList)
            {
                Assert.AreEqual(15, item);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DoNothingToCustomList_IterateThroughCustomList_ThrowsExceptionWhenAttemptedToAccessIndex0()
        {
            CustomList<int> myList = new CustomList<int>();

            foreach (int item in myList)
            {
                throw new Exception("There was an item in the CustomList");
            }

            myList[0] = 15;
        }

        [TestMethod]
        public void AddFiveItemsToCustomList_IterateThroughCustomList_ReturnsIndexFour()
        {
            CustomList<int> myList = new CustomList<int>();
            int indexCounter = 0;

            for(int i = 0; i < 5; i++)
            {
                myList.Add(i);
            }

            foreach (int item in myList)
            {
                if (indexCounter == 4)
                {
                    Assert.AreEqual(4, item);
                }
                indexCounter++;
            }
        }
    }
}
