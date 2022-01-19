
using System;
using System.Collections;

namespace DataStructuresCSharp
{
    /* One of the most important assumptions of the hash table is the possibility 
     * of very fast lookup for a Value based on the Key, which should be the O(1) operation.
     * To achieve this goal, the Hash function is used. It takes the Key to generate an index of a bucket,
     * where the Value can be found. */
    class HashTableDemo
    {
        public static void Demo()
        {
            Hashtable phonebook = new() // both key and value are of object type
            {
                { "Anjali", "9424689070" },
                { "Rohan", "00000007765" }
            };
            phonebook.Add("Aish", "22345");
            Console.WriteLine($"No of entries : {phonebook.Count}");
            foreach (DictionaryEntry value in phonebook)
            {
                Console.WriteLine($"{value.Key} : {value.Value}");
            }
        }
        /* We don't usually use this because this is non-generic */
    }

}
