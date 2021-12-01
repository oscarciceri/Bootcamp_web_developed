namespace POO1;

internal class ChairExample : IExecutableExample
{
    public void Execute()
    {
        Chair chair = new Chair();
        chair.Legs.Add(new Leg { Material = "Wood" });
        chair.Legs.Add(new Leg { Material = "Iron" });
        chair.Legs.Add(new Leg { Material = "Ruby" });
        chair.Legs.Add(new Leg { Material = "Carbon" });
        chair.PrintDetails();
    }

    public void Test()
    {
        throw new NotImplementedException();
    }
}
