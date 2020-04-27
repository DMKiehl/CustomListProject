using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void Add_AddingMultipleValuesToCutomList_AddedValueGoToIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int item2ToAdd = 5;
            int expected = 5;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingMultipleValueToCustomList_CountofCustomListIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int item2ToAdd = 5;
            int expected = 2;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddingMoreItemsThanInitialCapacityOfListArray_ArrayIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAdd2 = 9;
            int itemToAdd3 = 8;
            int itemToAdd4 = 7;
            int itemToAdd5 = 5;
            int expected = 5;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Add(itemToAdd5);
            actual = testList[4];


            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}
