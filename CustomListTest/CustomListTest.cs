using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Customlist1;


namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {




        //Add method tests
        [TestMethod]
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
            string expected = "134";
            //Act
            list.Remove(2);
            string actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
         
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
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
            string expected = "1234";
            //Act
            list.Remove(100);
            string actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
           
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
        [TestMethod]
        public void ToString_One()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            string expected = "1234";
            //Act
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_One_When_Nothing_Is_In_List()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            
            string expected = "";
            //Act
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Count_Check()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 4;
            //Act
            list.ToString();
            int actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Plus
        [TestMethod]

        
        public void Plus_Count_Goes_Up()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            CustomList<int> list2 = new CustomList<int>();
            list.Add(6);
            list.Add(7);
            list.Add(8);

            int expected = 6;
            //Act
            CustomList<int> list3 = new CustomList<int>();
            list3 = list + list2;
            int actual = list3.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_In_Action()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            
            CustomList<int> list2 = new CustomList<int>();
            list.Add(6);
            CustomList<int> list3 = new CustomList<int>();
            list3 = list + list2;
            
            int expected2 = 6;
            //Act
            
            int actual2 = list3[1];
            //Assert
            
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void Plus_Capacity_Goes_Up()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() {1, 2, 3, 4 };
          
            CustomList<int> list2 = new CustomList<int>() {9 };
            
            CustomList<int> list3 = new CustomList<int>();
            
            int expected = 8;
            //Act
            list3 = list + list2;
            int actual = list3.Capacity;           
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_Check_Capacity_Stays_The_Same_Before_Need_For_Double()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2};

            CustomList<int> list2 = new CustomList<int>() {8, 9};

            CustomList<int> list3 = new CustomList<int>();

            int expected = 4;
            //Act
            list3 = list + list2;
            int actual = list3.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Plus_Check_For_Order()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2 };

            CustomList<int> list2 = new CustomList<int>() { 8, 9 };

            CustomList<int> list3 = new CustomList<int>() { };

            string expected = "1289";
            //Act
            list3 = list + list2;
            string actual = list3.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
        //Minus
        [TestMethod]
        public void Minus_In_Action()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2 };

            CustomList<int> list2 = new CustomList<int>() { 1 };

            CustomList<int> list3 = new CustomList<int>();

            int expected = 2;
            //Act
            list3 = list - list2;
            int actual = list3[0];
            

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void Minus_Count()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 5, 6 };

            CustomList<int> list2 = new CustomList<int>() { 1, 5 };

            CustomList<int> list3 = new CustomList<int>();

            int expected = 2;
            //Act
            list3 = list - list2;
            int actual = list3.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Minus_Capacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 5, 6 };

            CustomList<int> list2 = new CustomList<int>() { 1, 5 };

            CustomList<int> list3 = new CustomList<int>();

            int expected = 4;
            //Act
            list3 = list - list2;
            int actual = list3.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Minus_Check_For_List_Of_Nothing()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() {};

            CustomList<int> list2 = new CustomList<int>() {1};

            CustomList<int> list3 = new CustomList<int>();

            int expected = 0;
            //Act
            list3 = list - list2;
            int actual = list3.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Minus_Check_For_Multiple()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() {1,5,6,7,1,1,1};

            CustomList<int> list2 = new CustomList<int>() { 1 };

            CustomList<int> list3 = new CustomList<int>();

            int expected = 6;
            //Act
            list3 = list - list2;
            int actual = list3.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Minus_Check_For_ArgumentOutOfRangeException()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 5, 6};

            CustomList<int> list2 = new CustomList<int>() { 1 };

            CustomList<int> list3 = new CustomList<int>();

            //int expected = 0;
            //Act
            list3 = list - list2;
            int actual = list3[2];


            //Assert
            

        }
    }
}
