namespace Exercise02;

public class TestClass
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("melak", 22);
        Person person2 = new Person("anai", 25);

        person1.PrintData();
        person2.PrintData();
    }
}
