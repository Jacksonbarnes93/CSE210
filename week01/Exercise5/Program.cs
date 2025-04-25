using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string input = Console.ReadLine();
        int number;

        while (!int.TryParse(input, out number))
        {
            Console.Write("That's not a valid number. Please enter a number: ");
            input = Console.ReadLine();
        }

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }

    // Main function
    static void Main()
    {
        DisplayWelcome();                      
        string userName = PromptUserName();    
        int favNumber = PromptUserNumber();    
        int squared = SquareNumber(favNumber); 
        DisplayResult(userName, squared);      
    }
}
