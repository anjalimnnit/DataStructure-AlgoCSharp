using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCSharp
{
    class DictionaryDemo
    {
        public static void Demo()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Anjali", "123");
            dict.Add("Rohan", "456");
            dict.Add("Aish", "789");
            foreach(var entry in dict)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            if (dict.ContainsKey("Aish"))
            {
                dict.Remove("Aish"); // Removes element from dic
            }
        }
    }
}
