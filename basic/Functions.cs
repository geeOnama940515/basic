/*Understanding Functions in C#
**Functions (also called methods in C#) allow us to reuse code, organize logic, and make our programs modular.
**This file contains examples of different types of functions in C#.
**1. Simple Function: A function that does not take any parameters or return a value.
**2. Function with Parameters and Return Type: A function that takes input parameters and returns a value.
**3. Function that Returns a String: A function that returns a string value.
*/

namespace basic; // Namespace declaration.

public class Functions // Define a class named Functions.
{
    // Constructor: This runs automatically when an object of Functions is created.
    public Functions()
    {
        Console.WriteLine("Welcome to Functions in C#!\n");

        // Call functions to demonstrate them.
        SayHello(); // Calls a function that prints a message.
        int sum = AddNumbers(5, 10); // Calls a function that adds two numbers and returns the result.
        Console.WriteLine($"Sum of 5 and 10 is: {sum}");

        string fullName = GetFullName("John", "Doe"); // Calls a function that returns a full name.
        Console.WriteLine($"Full Name: {fullName}");
    }

    // 1. Simple Function (No Parameters, No Return)
    private void SayHello()
    {
        Console.WriteLine("Hello! This is a function.");
    }

    // 2. Function with Parameters and Return Type
    private int AddNumbers(int a, int b)
    {
        return a + b; // Returns the sum of two numbers.
    }

    // 3. Function that Returns a String
    private string GetFullName(string firstName, string lastName)
    {
        return firstName + " " + lastName; // Combines first name and last name.
    }
}
