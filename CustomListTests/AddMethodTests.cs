using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddSingleVariable_CheckIndex0_ReturnsSameVariable()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 40;

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddSingleVariable_CheckIndex1_ThrowsException()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 40;

            //Act
            myList.Add(value);
            myList[1] = 0;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddSingleVariable_CheckIndexNegative1_ThrowsException()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 40;

            //Act
            myList.Add(value);
            myList[-1] = 0;

            //Assert
        }

        [TestMethod]
        public void AddTenVariables_CheckIndex0_ReturnsSameVariable()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int[] values = new int[10];

            //Act
            for(int i = 0; i < 10; i++)
            {
                values[i] = i;
                myList.Add(values[i]);
            }

            //Assert
            Assert.AreEqual(values[0], myList[0]);
        }

        [TestMethod]
        public void AddTenVariables_CheckIndex5_ReturnsSameVariable()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int[] values = new int[10];

            //Act
            for (int i = 0; i < 10; i++)
            {
                values[i] = i;
                myList.Add(values[i]);
            }

            //Assert
            Assert.AreEqual(values[5], myList[5]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddTenVariables_CheckIndex10_ThrowsException()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int[] values = new int[11];

            //Act
            for (int i = 0; i < 10; i++)
            {
                values[i] = i;
                myList.Add(values[i]);
            }
            myList[10] = 0;

            //Assert
            
        }

        [TestMethod]
        public void AddSingleVariable_CheckCount_Returns1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 40;

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(myList.Count, 1);
        }
    }
}
