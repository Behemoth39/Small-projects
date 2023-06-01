namespace WestcoastEducation;
public class AbStudent : AbCourseParticipant
{
    public Guid StudentId { get; } = Guid.NewGuid();
    public List<Course> Courses { get; set; } = new List<Course>();
    public Email? Email { get; set; }
    public override string FirstName { get; set; }
    public override string LastName { get; set; }
    public override string SocialSecurityNumer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string StreetAdress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string PostalCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public AbStudent(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override CourseParticipant Find(string firstName, string lastName)
    {
        return new CourseParticipant(firstName, lastName);
    }
    public override List<CourseParticipant> ListAll()
    {
        return new List<CourseParticipant>();
    }

    public override bool Validate()
    {
        Console.WriteLine("Student Valid");
        var validStudent = true;
        return validStudent;

    }
    public override bool Save()
    {
        return true;
    }

}