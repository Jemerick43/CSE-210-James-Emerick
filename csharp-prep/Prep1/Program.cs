using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string userFirstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string userLastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {userLastName}, {userFirstName} {userLastName}.");


    }
}