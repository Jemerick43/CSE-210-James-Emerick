using System.Reflection.Metadata.Ecma335;

abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        Console.WriteLine("Please enter desired color: ");
        _color = Console.ReadLine();
        return _color;
    }
    public abstract double GetArea();
}