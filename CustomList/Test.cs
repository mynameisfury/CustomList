using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Test
    {
        public void DisplayList()
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("3");
            list.Add("8");
            list.Add("5");
            list.Remove("8");
            Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
