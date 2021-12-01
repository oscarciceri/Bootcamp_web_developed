namespace POO1;

internal class Circle : Shape //(Circle herada de Shape) Los dos puntos indican la herencia o el uso de  una interfaz
                              // con una "," se puede agregar una interfaz
                              // Principios soid "herencia de una clase, pero con varias interfaces que no pertecen directamente a la clase"
{
    private double _radius;  //campos en clases tiene que ser private, formato _name

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea() //heradado de la clase shape, metodo abstracto -> tiene que ser implementado
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
