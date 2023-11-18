class Rectangle : Shape
{
    private double _side01;
    private double _side02;
    public Rectangle(string color, double side01, double side02) : base(color)
    {
        _side01 = side01;
        _side02 = side02;
    }
    public override double GetArea()
    {
        return _side01 * _side02;
    }
}