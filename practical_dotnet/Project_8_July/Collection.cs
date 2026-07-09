// Collection - group of object that can grow or shrink dynamically, can store similar type of data, can be accessed by index, can be traversed using loop
//list - dynamic array, automatically incr and decr 
// dictionary - key value pair, key is unique, value can be duplicate, can be accessed by key

using System.Collections.Generic;

class Collections
{
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Saloni");
        names.Add("Sakshi");
        names.Add("Kartik");
        names.Add("Rohit");
        names.Add("Aditya");

        foreach(string f in names) // display all the names in the list
        {
            Console.WriteLine(f);
        }
    }
}
