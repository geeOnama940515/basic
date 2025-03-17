/*
    * Loop.cs
    * This file contains examples of for and foreach loops.
    */

namespace basic;

public class Loop
{
    public Loop()
    {
        Console.WriteLine("Loop Examples:");
        RunForLoop();
        RunForEachLoop();
    }

    // For Loop Example
    private void RunForLoop()
    {
        Console.WriteLine("\nFor Loop Example:");

        // This loop runs from 1 to 5
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }
    }

    // Foreach Loop Example
    private void RunForEachLoop()
    {
        Console.WriteLine("\nForeach Loop Example:");

        string[] students = { "Alice", "Bob", "Charlie", "Dave" };

        // Iterates through the array and prints each student's name
        foreach (string student in students)
        {
            Console.WriteLine($"Student: {student}");
        }
    }
}
