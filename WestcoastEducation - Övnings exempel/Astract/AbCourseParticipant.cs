namespace WestcoastEducation;

public abstract class AbCourseParticipant
{
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
    public abstract string SocialSecurityNumer { get; set; }
    public abstract string StreetAdress { get; set; }
    public abstract string PostalCode { get; set; }
    public abstract string City { get; set; }
    public abstract string Phone { get; set; }

    public abstract CourseParticipant Find(string firstName, string lastName);
    public abstract List<CourseParticipant> ListAll();
    public abstract bool Validate();
    public abstract bool Save();

}