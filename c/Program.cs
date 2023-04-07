using System;

public class Man
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public double Weight { get; set; }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeAge(int newAge)
    {
        Age = newAge;
    }

    public void ChangeWeight(double newWeight)
    {
        Weight = newWeight;
    }
}






public class Student
{
    public Man Person { get; set; }
    public int EnrollmentYear { get; set; }

    public void ChangeEnrollmentYear(int newYear)
    {
        EnrollmentYear = newYear;
    }

    public void IncreaseEnrollmentYear()
    {
        EnrollmentYear++;
    }
}





class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт класу Man
        Man person = new Man();
        Console.Write("Enter person's name: ");
        person.Name = Console.ReadLine();
        Console.Write("Enter person's age: ");
        person.Age = int.Parse(Console.ReadLine());
        Console.Write("Enter person's gender: ");
        person.Gender = char.Parse(Console.ReadLine());
        Console.Write("Enter person's weight: ");
        person.Weight = double.Parse(Console.ReadLine());

        // Створюємо об'єкт класу Student
        Student student = new Student();
        student.Person = person;
        Console.Write("Enter enrollment year: ");
        student.EnrollmentYear = int.Parse(Console.ReadLine());

        // Виводимо інформацію про студента
        Console.WriteLine("Student's name: {0}", student.Person.Name);
        Console.WriteLine("Enrollment year: {0}", student.EnrollmentYear);

        // Змінюємо значення полів
        Console.Write("Enter new name: ");
        student.Person.ChangeName(Console.ReadLine());
        Console.Write("Enter new age: ");
        student.Person.ChangeAge(int.Parse(Console.ReadLine()));
        Console.Write("Enter new weight: ");
        student.Person.ChangeWeight(double.Parse(Console.ReadLine()));
        student.IncreaseEnrollmentYear();

        // Виводимо оновлену інформацію про студента
        Console.WriteLine("Updated student's name: {0}", student.Person.Name);
        Console.WriteLine("Updated student's age: {0}", student.Person.Age);
        Console.WriteLine("Updated student's weight: {0}", student.Person.Weight);
        Console.WriteLine("Updated enrollment year: {0}", student.EnrollmentYear);

        Console.ReadKey();
    }
}

