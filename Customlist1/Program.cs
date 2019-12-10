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
            CustomList<int> list = new CustomList<int>() { 1, 3, 5 };

            CustomList<int> list2 = new CustomList<int>() { 2 };

            CustomList<int> list3 = new CustomList<int>();

            string expected = "1235";
            //Act
            list3 = list.Zip(list2);
            string actual = list3.ToString();
        }
    }
}
