namespace Exercise02;

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintData()
    {
        Console.WriteLine($"Name: {Name} and Age: {Age}");
    }
}
