namespace WestcoastEducation;
public class StudentI : ICourseParticipant
{
    public Guid StudentId { get; } = Guid.NewGuid();
    public List<Course> Courses { get; set; } = new List<Course>();
    public Email? Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SocialSecurityNumer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string StreetAdress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string PostalCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public StudentI(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public CourseParticipant Find(string firstName, string lastName)
    {
        return new CourseParticipant(firstName, lastName);
    }
    public List<CourseParticipant> ListAll()
    {
        return new List<CourseParticipant>();
    }

    public bool Validate()
    {
        Console.WriteLine("Student Valid");
        var validStudent = true;
        return validStudent;

    }
    public bool Save()
    {
        return true;
    }

}