using System;

namespace basic;

public class Calculator
{
    public Calculator()
    {      
    Console.WriteLine("=== Calculator ===");
    Console.Write("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter operator (+, -, *, /): ");
    string op = Console.ReadLine()!;
    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    switch(op)
    {
        case "+":
            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            break;
        case "/":
            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            break;
        default:
            Console.WriteLine("Invalid operator");
            break;
    }
    }
}
