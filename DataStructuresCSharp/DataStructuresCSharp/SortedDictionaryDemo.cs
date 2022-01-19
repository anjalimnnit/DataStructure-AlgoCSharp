using System;
using System.Collections.Generic;

namespace DataStructuresCSharp
{
    class SortedDictionaryDemo
    {
        public static void Demo()
        {
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
            dict["Anjali"] = "123";
            dict.Add("Rohan", "456");
            dict.Add("Aish", "789");
            foreach (var entry in dict)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }
        
}
}
