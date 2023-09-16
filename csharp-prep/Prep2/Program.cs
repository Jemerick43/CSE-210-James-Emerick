using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        string userGPA = Console.ReadLine();
        int gradePointAverage = int.Parse(userGPA);
        string letter;

        if (gradePointAverage >= 90)
        {
            letter = "A";
        }
        else if (gradePointAverage >= 80 && gradePointAverage <= 90)
        {
            letter = "B";
        }
        else if (gradePointAverage >= 70 && gradePointAverage <= 80)
        {
            letter = "C";
        }
        else if (gradePointAverage >= 60 && gradePointAverage <= 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradePointAverage >= 70)
        {
            Console.WriteLine("You have passed the course! \n\nCongratulations!!\n\n");
        }
        else
        {
            Console.WriteLine("You did not pass the course! \n\nDon't Give Up!! You can do this!\n\n");
        }
    }
}