using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You got a C!");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got a D!");
            }
            else
            {
                Console.WriteLine("You got an F!");
            }
           if (grade >= 70)
            {
                Console.WriteLine("You passed the class! ");
            }
            else
            {
                Console.WriteLine("You did not pass the class. ");
            }
        }
    }
}
