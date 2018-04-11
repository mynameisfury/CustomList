using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_AddToList_AddedToEndOfList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(2);
            customList.Add(3);
            //assert
            Assert.AreEqual(customList.array[1], 3);
        }
        [TestMethod]
        public void Add_AddToList_CountIncrements()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(3);
            //assert
            Assert.AreEqual(customList.Count, 1);
        }
        [TestMethod]
        public void Add_AddToList_CapacityIncreases()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(3);
            customList.Add(7);
            customList.Add(4);
            customList.Add(9);
            customList.Add(8);
            customList.Add(45);
            customList.Add(1);
            customList.Add(2);
            //assert
            Assert.AreEqual(customList.Count, 8);
        }
        //check index, count, capacity
        [TestMethod]
        public void Remove_RemoveFromList_CountIsDecremented()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(5);
            customList.Remove(3);
            customList.Add(4);
            //assert
            Assert.AreEqual(customList.Count, 2);

        }
        [TestMethod]
        public void Remove_RemoveFromList_IndexIsNotTheSame()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(5);
            customList.Remove(3);
            customList.Add(4);
            //assert
            Assert.AreEqual(customList[1], 4);

        }
        [TestMethod]
        public void ToString_CheckIfString_IsString()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            //act
            customList.Add(4);
            customList.Add(3);
            customList.Add(6);
            customList.Add(5);
            customList.ToString();
            //assert
            Assert.AreEqual(customList, "4, 3, 6, 5");
        }
        public void ToString_ToStringANull_ErrorMessage()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            //act
            customList.Add();
            customList.ToString();
            //assert
            Assert.AreEqual(customList[0], null);
        }
        


    }
}
