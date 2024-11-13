using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPrograms
{
    internal class HashSet
    {
        static void Main(string[] args)
        {
            //HashSet
            // duplicates are not allowed
            HashSet<string> set = new HashSet<string>();

            set.Add("Kunali");
            set.Add("Ishwari");
            set.Add("Megha");
            set.Add("Sonam");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
