using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Simple Calculator!");
        Console.WriteLine("Please choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int choice;
        double num1, num2, result;

        Console.Write("Enter your choice (1/2/3/4): ");
        choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                break;
        }
    }

 



    public void Mymethod()
    {
        int pin = 1234; // Change this to your desired PIN

        Console.WriteLine("Welcome to the ATM.");
        Console.Write("Please enter your PIN: ");
        int enteredPin;

        if (int.TryParse(Console.ReadLine(), out enteredPin))
        {
            if (enteredPin == pin)
            {
                Console.WriteLine("PIN accepted. Access granted.");
                // You can place your ATM functionality here.
            }
            else
            {
                Console.WriteLine("Incorrect PIN. Access denied.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric PIN.");
        }
    }
}
