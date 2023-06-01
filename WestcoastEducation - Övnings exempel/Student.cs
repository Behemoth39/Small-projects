namespace WestcoastEducation;
public class Student : CourseParticipant
{
    public Guid StudentId { get; } = Guid.NewGuid();
    public List<Course> Courses { get; set; } = new List<Course>();
    public Email? Email { get; set; }

    public Student(string firstName, string lastName) : base(firstName, lastName) { }

    public override bool Validate()
    {
        Console.WriteLine("Student Valid");
        var validStudent = true;
        return validStudent;

    }

}