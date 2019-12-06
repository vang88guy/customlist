using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTest;
using xunity; 

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void CountTest()
        {
            //Arrange

            //Act

            //Assert
            
        }


//Add method tests
        [TestMethod]
        public void Add_New_Item_List()
        {
            //Arrange
            CustomList <int> list;
            int expected = 4;

            //Act
            list.Addto(4);
            int actual = list[0];
            //Assert
            Assert.Equals(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Does_not_Add_To_Beginning() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "hi", "bye" };
            string expected = "hi";
            //Act
            list.Addto("goodbye");
            string actual = list[0];
            //Assert
            Assert.Equals(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Does_Not_Get_Added_To_Middle() 
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "hi", "bye" };
            string expected = "bye";
            //Act
            list.Addto("goodbye");
            string actual = list[1];
            //Assert
            Assert.Equals(expected, actual);
        }
        [TestMethod]
        public void Add_Item_Make_Count_Goes_Up() 
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
