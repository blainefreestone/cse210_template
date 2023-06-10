using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userNumber = -1;

        while (userNumber != magicNumber)
        {
            Console.WriteLine("What is the magic number? ");
            string userNumberInText = Console.ReadLine();
            userNumber = int.Parse(userNumberInText);

            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}