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

            string output =  list.ToString();

            Console.WriteLine(output);
            Console.ReadLine();
            
        }
    }
}
