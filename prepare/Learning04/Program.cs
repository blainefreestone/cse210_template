using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Blaine Freestone", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Blaine Freestone", "Discrete Mathamatics", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Blaine Freestone", "American History", "The Age of Jackson");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInfo());
    }
}