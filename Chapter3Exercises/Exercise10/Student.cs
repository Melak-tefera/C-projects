namespace Exercise10;

public class Student
{
    private string fullName;
    private string course;
    private string subject;
    private string university;
    private string email;
    private string phoneNumber;

    public static int StudentCount { get; private set; }

    public string FullName { get => fullName; set => fullName = value; }
    public string Course { get => course; set => course = value; }
    public string Subject { get => subject; set => subject = value; }
    public string University { get => university; set => university = value; }
    public string Email { get => email; set => email = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    public Student() : this("Not provided", "Not provided", "Not provided", "Not provided", "Not provided", "Not provided") { }

    public Student(string fullName) : this(fullName, "Not provided", "Not provided", "Not provided", "Not provided", "Not provided") { }

    public Student(string fullName, string course, string subject)
        : this(fullName, course, subject, "Not provided", "Not provided", "Not provided") { }

    public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
    {
        FullName = fullName;
        Course = course;
        Subject = subject;
        University = university;
        Email = email;
        PhoneNumber = phoneNumber;
        StudentCount++;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Full name: {FullName}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"University: {University}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
    }
}
