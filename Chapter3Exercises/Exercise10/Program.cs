namespace Exercise10;

public class StudentTest
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Abebe Kebede", "Computer Science", "Programming",
                                       "Unity University", "abebe@example.com", "0911000000");
        Student student2 = new Student("Meron Alemu", "Information Technology", "Database");
        Student student3 = new Student("Sara Bekele");

        Console.WriteLine("STUDENT 1");
        student1.DisplayInformation();
        Console.WriteLine("\nSTUDENT 2");
        student2.DisplayInformation();
        Console.WriteLine("\nSTUDENT 3");
        student3.DisplayInformation();
        Console.WriteLine($"\nTotal student objects created: {Student.StudentCount}");
    }
}
