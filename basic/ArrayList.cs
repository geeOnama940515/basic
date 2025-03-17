/*
C# provides two types of collections to store multiple items: arrays and lists. An array is a fixed-size collection, while a list is a dynamic-size collection. In this example, we demonstrate how to declare, initialize, and access elements in arrays and lists.
*/

namespace basic; // Namespace declaration.

public class ArrayListExample // Class to demonstrate arrays and lists.
{
    public ArrayListExample()
    {
        // ======= ARRAYS =======
        Console.WriteLine("=== Arrays ===");

        // 1️⃣ Declare and initialize an array (fixed size)
        int[] numbers = { 10, 20, 30, 40, 50 };

        // 2️⃣ Access array elements by index
        Console.WriteLine($"First element: {numbers[0]}"); // 10

        // 3️⃣ Loop through an array using for loop
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // 4️⃣ Loop through an array using foreach
        Console.WriteLine("Array using foreach:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // ======= LIST<T> (Dynamic Array) =======
        Console.WriteLine("\n=== List<T> ===");

        // 1️⃣ Declare and initialize a List
        List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };

        // 2️⃣ Add elements to the list
        names.Add("David");
        names.Add("Eve");

        // 3️⃣ Access elements
        Console.WriteLine($"First name: {names[0]}"); // Alice

        // 4️⃣ Loop through the list
        Console.WriteLine("List elements:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 5️⃣ Remove an element
        names.Remove("Charlie");

        // 6️⃣ Display list after removal
        Console.WriteLine("List after removing 'Charlie':");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
