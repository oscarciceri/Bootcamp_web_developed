namespace UniArroyo;
internal class Users : interfaceUsers
{
    private string _name;
    private string _birthday;
    private string _email;
    private string _password;


    public Users(string name, string email, string password, string birthday)
    {
        this._name = name;
        this._email = email;
        this._password = password;
        this._birthday = birthday;
    }


    public void CreateProfessor()
    {   
        UsersTypes professor = new Professor("Computer Science", 10);
        Console.WriteLine($"Professsor: {professor.showData()}");
    }

    internal void computeScoreStudent()
    {
        Console.WriteLine("\nCompute Data");
        var student = new List<ClassType>();
        student.Add(new Math { cheating = 0, possitve_points = 8, negative_points = 3 });
        student.Add(new Math { cheating = 1, possitve_points = 10, negative_points = 0 });
        student.Add(new Math { cheating = 0, possitve_points = 6, negative_points = 5 });

        int number_approved = 0;
        foreach (var i in student)
        {
            number_approved += i.Calculate();
            Console.WriteLine($"Value: {number_approved}");
         

        }
        Console.WriteLine($"Number of approved students: {number_approved}");
    }

    public void CreateStudent() {
        UsersTypes student = new Student("Arroyo Lab", 9.5);
        Console.WriteLine($"Student: {student.showData()}");

    }



    public void showDataUser()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Email: {_email}");
        Console.WriteLine($"Password: {_password}");
    }

}