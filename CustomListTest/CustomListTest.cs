using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Customlist1;


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
       
        public void Add_New_Item_To_List()
        {
            //Arrange
            CustomList <int> list = new CustomList<int>();
            int expected = 4;

            //Act
            list.Add(4);
            int actual = list[0];
            //Assert
            Assert.Equals(expected, actual);
        }
      
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
            Assert.Equals(expected, actual);
        }
      
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
            Assert.Equals(expected, actual);
        }
      
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
            Assert.Equals(expected, actual);
        }
     
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
            Assert.Equals(expected, actual);
        }
    }
}
