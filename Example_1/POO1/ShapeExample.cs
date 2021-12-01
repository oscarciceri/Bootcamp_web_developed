namespace POO1;

internal class ShapeExample : IExecutableExample // : para usar la interfaz IExecutableExample
{
    public void Execute()
    {
        Shape circle = new Circle(2);
        Shape square = new Square(2);

      

        Console.WriteLine($"Circle area is {circle.CalculateArea()}");

        Console.WriteLine($"Square area is {square.CalculateArea()}");
    }

    public void Test()
    {
        throw new NotImplementedException(); //Exeption of non-implemented
    }

    
}
