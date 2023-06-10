using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);

        if (grade >= 90) 
        {
            string letter = "A";
        }
        else if (grade >= 80)
        {
            string letter = "A";
        }
        else if (grade >= 70)
        {
            string letter = "A";
        }
        else if (grade >= 60)
        {
            string letter = "A";
        }
        else
        {
            string letter = "A";
        }

        Console.WriteLine($"{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class! Congratulations!!!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class :( Better luck next time!!!");
        }
    }
}