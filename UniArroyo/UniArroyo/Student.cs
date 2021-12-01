namespace UniArroyo;

internal class Student : UsersTypes
{
    private string _laboratory;
    private double _meanScore;

    public Student(string v1, double v2)
    {
        this._laboratory = v1;
        this._meanScore = v2;
    }

    public override string showData()
    {
        Console.WriteLine($"Student created with mean score:  {_meanScore}");
        return _laboratory;
    }

}
