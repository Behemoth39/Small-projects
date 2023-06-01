namespace WestcoastEducation;
public class Teacher : CourseParticipant
{
    public Guid TeacherId { get; } = Guid.NewGuid();
    public List<Course> Courses { get; set; } = new List<Course>();
    public Email? Email { get; set; }

    public Teacher(string firstName, string lastName) : base(firstName, lastName) { }

    public override bool Validate()
    {
        Console.WriteLine("Teacher Valid");
        var validTeacher = true;
        return validTeacher;

    }
}