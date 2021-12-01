using UniArroyo;

Console.WriteLine("Hello UNIARROYO!");

//Homework 1
Console.WriteLine("\nProfessor!");
var user1 = new Users("Prof Arroyo", "prof@arroyo.net", "prof", "1990");
user1.CreateProfessor();
user1.showDataUser();

Console.WriteLine("\nStudent!");
var user2 = new Users("Arroyo", "student@arroyo.net", "student", "2000");
user2.CreateStudent();
user2.showDataUser();

//Homework 2
user2.computeScoreStudent();




