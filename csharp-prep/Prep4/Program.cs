using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int input = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Creates list based on user input.
        do
        {
            Console.Write("Enter number: ");
            string inputInText = Console.ReadLine();
            input = int.Parse(inputInText);

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Compute sum, average, and largest number.
        int runningSum = 0;
        int runningCount = 0;
        int runningMax = -9999;

        foreach (int number in numbers)
        {
                runningCount += 1;
                runningSum += number;
                
                if (number > runningMax)
                {
                    runningMax = number;
                }
        }

        int average = runningSum / runningCount;

        Console.WriteLine($"The sum is: {runningSum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {runningMax}");

    }
}