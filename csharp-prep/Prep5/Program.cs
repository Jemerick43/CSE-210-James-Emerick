using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userName = ""; //JE
        Console.WriteLine("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber = 0;
        Console.WriteLine("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int baseNumber)
    {
        int squaredNumber = baseNumber * baseNumber;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine("{0}, the square of your number is {1}", userName, squareNumber);
    }
}