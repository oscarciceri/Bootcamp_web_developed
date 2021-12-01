namespace POO1;

internal class Chair
{
    // public List<Leg> Legs { get; set; } = new List<Leg>(); //clase listas genericas o de clase especifica 
    //esta es clase este llena con clase leg, y como lista vacia 


    public List<Leg> Legs { get; set; } //clase listas genericas o de clase especifica 
                                                           //esta es clase este llena con clase leg, y como lista vacia 
    public string? Color { get; set; } //clase string que permite tener un valor (puede definir acceso)


    public Chair() //constructor
    {
        Legs = new List<Leg>();
    }


    public void PrintDetails()
    {
        int i = 0;
        Console.WriteLine($"This is a {Color} chair with {Legs.Count} legs");
        foreach (Leg leg in Legs)
        {
            Console.WriteLine($"This is a {leg.Material} leg");
        }
    }
}
