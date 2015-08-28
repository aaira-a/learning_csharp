using System;
using System.Collections.Generic;

public class Tutorial
{
    public static void Main()
    {
        List<int> primeNumbers = new List<int>();

        primeNumbers.Add(1);
        primeNumbers.Add(2);
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);

        Console.WriteLine(primeNumbers.Count);
        Console.WriteLine(primeNumbers[0]);
        Console.WriteLine(primeNumbers[1]);
        Console.WriteLine(primeNumbers[2]);
        Console.WriteLine(primeNumbers[3]);
        Console.WriteLine(primeNumbers[4]);
    }
}
