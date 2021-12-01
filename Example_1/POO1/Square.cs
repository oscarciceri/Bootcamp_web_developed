namespace POO1;

internal class Square : Shape
{
    private double _sideLong;

    public Square(double sideLong)
    {
        _sideLong = sideLong;
    }

    public override double CalculateArea()
    {
        return Math.Pow(_sideLong, 2);
    }
}

