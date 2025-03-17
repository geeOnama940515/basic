/*

    Understanding Objects in C#
Objects are instances of classes. In C#, we use classes to define blueprints for objects, and then we create objects from those classes.

    This file contains the definition of a class called Person.
    The class has two fields (name and age) and a constructor to initialize them.
    It also has a method called Introduce to display the person's details.
*/

namespace basic; // Namespace declaration.

public class Person // Define a class called Person.
{
    // Fields (or attributes) - These store data about the person.
    private string name;
    private int age;

    // Constructor: This is called when an object of Person is created.
    public Person(string name, int age)
    {
        this.name = name; // Assign the parameter value to the class field.
        this.age = age;
    }

    // Method to display the person's details.
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    }
}
