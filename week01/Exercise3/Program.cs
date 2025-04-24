using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1,101); //This will generate a random number between 1 and 100
        int userGuess = 0; //this will store the user's guess   

        while (userGuess != numberToGuess)
        {
            Console.WriteLine("Guess a number between 1 and 100:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
    }
}