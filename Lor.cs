using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Create a new object
        var myObj = new Object();

        // Store the object in a variable
        var storedObj = myObj;

        // Assert that storedObj is not null
        Debug.Assert(storedObj != null, "storedObj is null");

        // Print the type of storedObj
        Console.WriteLine(storedObj.GetType());

        // Set storedObj to null
        storedObj = null;

        // Assert that storedObj is not null
        // This assertion will fail and throw an exception
        Debug.Assert(storedObj != null, "storedObj is null");
    }
}
