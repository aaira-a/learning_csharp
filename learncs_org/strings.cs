using System;

public class Tutorial
{
    public static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        int age = 27;

        string sentence = String.Format("{0} {1} is {2} years old.",
                                         firstName, lastName, age);

        Console.WriteLine(sentence);
    }
}
