class Circle : Shape
{
    private double _diameter;
    public Circle(string color, double side) : base(color)
    {
        _diameter = side;
    }
    public override double GetArea()
    {
        return Math.PI * (_diameter / 2) * (_diameter / 2);
    }
}