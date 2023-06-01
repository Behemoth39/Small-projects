namespace WestcoastEducation;
class Program
{
    static void Main(string[] args)
    {
        var participantList = new List<CourseParticipant>();

        var student = new Student("Kalle", "Jansson")
        {
            SocialSecurityNumer = "1995-13-02-XXXX",
            StreetAdress = "Kövle 1",
            PostalCode = "584 12",
            City = "Lönnedal",
            Phone = "0703661419"
        };
        var studentemail = new Email();
        studentemail.Emails = "Kalle@gmail.com";
        student.Email = studentemail;
        participantList.Add(student);


        var teacher = new Teacher("Hanna", "Aronsson")
        {
            SocialSecurityNumer = "1982-03-10-XXXX",
            StreetAdress = "Rådhusgatan",
            PostalCode = "541 30",
            City = "Skövde",
            Phone = "0726558917"
        };
        var teacheremail = new Email();
        teacheremail.Emails = "Hanna@gmail.com";
        teacher.Email = teacheremail;
        participantList.Add(teacher);


        foreach (var participant in participantList)
        {
            Console.WriteLine("\nParticipant: {0} {1}\n" + "{2}\n" + "{3}\n" + "{4}\n" + "{5}\n" + "{6}\n" + "{7}",
            participant.FirstName, participant.LastName, participant.SocialSecurityNumer, participant.StreetAdress, participant.PostalCode, participant.City, participant.Phone, participant.Email);

            participant.Validate();
        }

    }
}
