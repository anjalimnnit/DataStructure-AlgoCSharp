using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCSharp
{
    class HashSetDemo
    {
        /* Collection of distinct objects */
        public static void Demo()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(12);
            numbers.Add(12);
            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(3);

            HashSet<int> primenumbers = new HashSet<int>();
            primenumbers.Add(1);
            primenumbers.Add(3);
            primenumbers.Add(5);
            primenumbers.Add(5);
            primenumbers.Add(7);

            Console.WriteLine("Intersectio between numbers and prime numbers:");
            numbers.IntersectWith(primenumbers);
            foreach (var val in numbers)
            {
                Console.WriteLine(val);
            }
        }
        
    }
}
