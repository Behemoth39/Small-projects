namespace WestcoastEducation;

public class CourseParticipant
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumer { get; set; } = "";
    public string StreetAdress { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string Phone { get; set; } = "";

    public CourseParticipant(string firstName, string lastName)
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

    public virtual bool Validate()
    {
        Console.WriteLine("Participant Valid");
        var validParticipant = true;
        return validParticipant;
    }
    public bool Save()
    {
        return true;
    }
}