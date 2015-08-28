using System;
using System.Collections.Generic;

public class Tutorial
{
    public static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        inventory["apple"] = 3;
        inventory.Add("orange", 5);
        inventory["banana"] = 2;

        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);
    }
}
