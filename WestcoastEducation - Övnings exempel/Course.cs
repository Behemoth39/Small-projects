namespace WestcoastEducation;
public class Course
{
    public Guid CourseId { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public DateTime CourseStart { get; set; }
    public DateTime CourseEnd { get; set; }
    public string CourseNumer { get; set; } = "";

    public bool Save()
    {
        return true;
    }
    public bool Validate()
    {
        var validCourse = true;
        return validCourse;
    }

    public Course Find(string courseid)
    {
        return new Course();
    }
    public List<Course> ListAll()
    {
        return new List<Course>();
    }
}