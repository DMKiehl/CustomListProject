﻿using System;
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

        //Remove Test Methods
        [TestMethod]
        public void Remove_RemoveOneItemFromIndexZero_RemainingValueMovesToIndexZero()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int item2ToAdd = 5;
            int expected = 5;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);

            testList.Remove(10);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_CountOfCustomListIncrementsDown()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int item2ToAdd = 5;
            int item3ToAdd = 8;
            int expected = 2;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            testList.Add(item3ToAdd);

            testList.Remove(8);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        
        public void Remove_RemoveAValueFromAListWhenAllValueAreTheSame_OneValueIsRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 5;
            int item2ToAdd = 5;
            int item3ToAdd = 5;
            int expected = 2;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            testList.Add(item3ToAdd);

            testList.Remove(5);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Remove_RemoveMultipleItemsFromList_CountOfCustomListIncrementsDownMulitple()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int item2ToAdd = 5;
            int item3ToAdd = 8;
            int expected = 1;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            testList.Add(item3ToAdd);

            testList.Remove(8);
            testList.Remove(10);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMultipleValuesFromList_RemainingValuesMoveDownIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 12;
            int item2ToAdd = 6;
            int item3ToAdd = 9;
            int expected = 6;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            testList.Add(item3ToAdd);

            testList.Remove(9);
            testList.Remove(12);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveAValueThatIsNotContainedInList_ReturnFalse()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 12;
            int item2ToAdd = 6;
            int item3ToAdd = 9;
            bool expected = false;
            bool actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(item2ToAdd);
            testList.Add(item3ToAdd);

            actual = testList.Remove(15);
            

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
