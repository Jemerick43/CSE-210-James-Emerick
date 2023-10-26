using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new("Bro C", "CS210");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMath = new("Roberto Rodriguez", "Fractions", "SectionCharacteristics 7.3", "Problems 8-19");
        Console.WriteLine(myMath.GetSummary());
        Console.WriteLine(myMath.GetHomeworkList());
        WritingAssignment myWriting = new("Mary Waters", "European History", "The causes of WWII by Mary Waters");
        Console.WriteLine(myWriting.GetSummary());
        Console.WriteLine(myWriting.GetWritingInformation());
    }
}