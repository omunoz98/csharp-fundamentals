﻿namespace MyFirstApplication;

// lesson 16 collections

internal class Lesson16
{
    /*
     The list <T> is the same as an ArrayList, but we define
    our type in it declaration as all times are of the same type.
     */

    public void MyListExample()
    {
        List<string> myStringList = new List<string>();
        myStringList.Add("Alpha");
        myStringList.Add("Bravo");
        myStringList.Add("Charlie");
        myStringList.Add("Delta");
        myStringList.Add("Echo");
        myStringList.Add("Foxtrot");

        // Gets or set the total number of elements
        Console.WriteLine($"capacity is {myStringList.Capacity}");
        Console.WriteLine($"Total count is {myStringList.Count}");

        // Bool if list contains?
        Console.WriteLine($"This list might contain {myStringList.Contains("Delta")}");

        // insert and remove items
        myStringList.Insert(3, "Happy");
        myStringList.Remove("Happy");

        // iterate through the elements
        foreach (string item in myStringList)
        {
            Console.WriteLine(item);
        }
    }
        /*
         This collection is based around key value pairs
         */
        public void MyDictionaryExample()
        {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
        phrases.Add(10, "CSharp");
        phrases.Add(20, "Rocks");
        phrases.Add(30, "Happy");
        phrases.Add(40, "Friday");


        // get a single value using TryGetValue Method
        string value;
        if(phrases.TryGetValue(20, out value))
        {
            Console.WriteLine($"For key 20, the value is {value}");
        }

        // iterate through the list
        foreach (KeyValuePair<int, string> item in phrases)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }


        }



    




} // end class 
