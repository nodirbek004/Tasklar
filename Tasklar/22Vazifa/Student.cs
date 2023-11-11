namespace Tasklar._22Vazifa;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Credit { get; set; }
    public decimal Contract { get; set; }
    public string UniversityName { get; set; }
    public string UniversityFaculty { get; set; }
    public string UniversityBranch { get; set; }
    public int Course { get; set; }
    public bool isDistance { get; set; }

    public static List<Student> GetAllStudents { get; set; } = new List<Student>()
        {

            new Student()
            {
                Id=1,
                FirstName = "Rustambek",
                LastName = "Jurayev",
                Age = 23,
                Credit = 4,
                Contract = 9_000_000,
                UniversityName = "MIT",
                UniversityBranch = "New-York",
                UniversityFaculty = "AI",
                Course = 2,
                isDistance = true,
            }
     
}
