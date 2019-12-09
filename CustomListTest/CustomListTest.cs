using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Customlist1;


namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
       


//Add method tests
       
        public void Add_New_Item_To_List()
        {
            //Arrange
            CustomList <int> list = new CustomList<int>();
            int expected = 4;

            //Act
            list.Add(4);
            int actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Does_Not_Add_To_Beginning() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("hi");
            list.Add("bye");
            string expected = "hi";
            //Act
            list.Add("goodbye");
            string actual = list[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Does_Not_Change_Items_Already_In_Array() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("hi");
            list.Add("bye");
            string expected = "bye";
            //Act
            list.Add("goodbye");
            string actual = list[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Makes_Capacity_Goes_Up()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 5;
            //Act
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Increases_Count_By_One() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            list.Add("hi");
            
            int expected = 2;
            //Act
            list.Add("bye");
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Item_Does__Not_Change_List_order()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected1 = 1;
            int expected2 = 3;
            int expected3 = 4;
            //Act
            list.Remove(2);
            int actual1 = list[0];
            int actual2 = list[1];
            int actual3 = list[2];
            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Remove_Item_Change_Capacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 4;
            //Act
            list.Remove(4);
            int actual = list.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Item_Change_Count()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 3;
            //Act
            list.Remove(4);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Item_Removes_Only_One_Number_At_A_Time()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int expected = 3;
            //Act
            list.Remove(1);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_Item_IndexOutofrange()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
            list.Remove(1);
            int actual = list[4];
            //Assert


        }

        // position if nothing is removed
        [TestMethod]
        public void Remove_Item_That_Does_Not_Exist()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 3;
            int expected4 = 4;
            //Act
            list.Remove(100);
            int actual1 = list[0];
            int actual2 = list[1];
            int actual3 = list[2];
            int actual4 = list[3];
            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
        // count if nothing is removed
        public void Remove_Item_That_Does_Not_Exist_Count_Stays_The_Same()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 4;

            //Act
            list.Remove(100);
            int actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //[TestMethod]
        //public void Remove_Item_That_Does_No()
        //{
        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    list.Add(1);
        //    list.Add(2);
        //    list.Add(3);
        //    list.Add(4);
        //    int expected1 = 1;
        //    int expected2 = 2;
        //    int expected3 = 3;
        //    int expected4 = 4;
        //    //Act
        //    list.Remove(100);
        //    int actual1 = list[0];
        //    int actual2 = list[1];
        //    int actual3 = list[2];
        //    int actual4 = list[3];
        //    //Assert
        //    Assert.Equals(expected1, actual1);
        //    Assert.Equals(expected2, actual2);
        //    Assert.Equals(expected3, actual3);
        //    Assert.Equals(expected4, actual4);
        //}
    }
}
