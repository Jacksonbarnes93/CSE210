using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = [];
        Console.WriteLine("Enter numbers one by one. Type 0 to finish:");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                    break;

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0]; // we are going the current number is the biggest 

            foreach (int num in numbers)
            {
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"\nYou entered {numbers.Count} numbers.");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Largest number: {max}");
        }
        else
        {
            Console.WriteLine("You didn't enter any numbers.");
        }
    }
}
