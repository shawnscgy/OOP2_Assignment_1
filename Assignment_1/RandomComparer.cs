using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class RandomComparer
    {
        public static void Comparer(List<int> indexes, List<Appliance> list)
        {
            foreach(int i in indexes)
            {
                Console.WriteLine(list[i]);
                Console.WriteLine();
            }
        }
    }
}
