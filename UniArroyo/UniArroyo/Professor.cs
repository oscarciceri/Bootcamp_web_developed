namespace UniArroyo;

internal class Professor : UsersTypes
{

    private string _institute;
    private double _impactFactor;

    public Professor(string institute, double impactFactor) 
    {
        _institute = institute;
        _impactFactor = impactFactor;
    
    }


    public override string showData()
    {
        Console.WriteLine($"Proffesor created with Impact Factor: {_impactFactor}");
        return _institute;
    }

 
}

