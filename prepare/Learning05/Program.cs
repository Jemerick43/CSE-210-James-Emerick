using System;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new("red", 2);
        Console.WriteLine("{0}{1}", newSquare.GetColor(), newSquare.GetArea());
        Rectangle newRect = new("blue", 1, 2);
        Console.WriteLine("{0}{1}", newRect.GetColor(), newRect.GetArea());
        Circle newCirc = new("green", 2);
        Console.WriteLine("{0}{1}", newCirc.GetColor(), newCirc.GetArea());
    }
}