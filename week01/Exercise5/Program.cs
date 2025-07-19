using System;

class Program
{
    static void Main(string[] args)
    {
        ShowGreeting();

        string user = AskForName();
        int favNumber = GetFavoriteNumber();

        int result = CalculateSquare(favNumber);

        ShowFinalMessage(user, result);
    }

    static void ShowGreeting()
    {
        Console.WriteLine("Hello! This is a simple C# program.");
    }

    static string AskForName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int CalculateSquare(int num)
    {
        return num * num;
    }

    static void ShowFinalMessage(string userName, int squared)
    {
        Console.WriteLine($"{userName}, your favorite number squared is {squared}.");
    }
}
