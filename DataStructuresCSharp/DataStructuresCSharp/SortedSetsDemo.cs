using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCSharp
{
    class SortedSetsDemo
    {
        public static void Demo()
        {
            SortedSet<string> names = new SortedSet<string>
            {
                "Anjali",
                "Zeeinith",
                "Rohan",
                "Aniraj",
                "Vishnu",
                "Aishwarya",
                "Shalini",
                "Anjali",
                "Aniraj"
            };
            foreach(var name in names)
            {
                Console.WriteLine($"Names in ascending order: {name}");
            }
        }
    }
}
