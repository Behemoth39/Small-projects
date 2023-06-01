namespace WestcoastEducation;

public interface ICourseParticipant
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string SocialSecurityNumer { get; set; }
    string StreetAdress { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }
    string Phone { get; set; }

    CourseParticipant Find(string firstName, string lastName);
    List<CourseParticipant> ListAll();
    bool Validate();
    bool Save();

}