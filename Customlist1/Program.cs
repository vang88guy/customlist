using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customlist1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>() { 1,2,3,4,5};
            
            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 3;
            int expected4 = 4;
            //Act
            list.Remove(100);
            int actual1 = list[0];
            int actual2 = list[1];
            int actual3 = list[2];
            int actual5 = list[4];
            int actual4 = list[3];
            //Assert
            
        }
    }
}
