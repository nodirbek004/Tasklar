namespace Tasklar._22Vazifa;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public float Salary { get; set; }
    public string? Level { get; set; }
    public List<string> Skills { get; set; }
    public List<string> Languages { get; set; }
    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1001,
                Age = 15,
                FirstName = "nodir",
                LastName = "ollonazarov",
                Salary = 200,
                Level = "Stajor",
                Skills = new List<string>
                {
                    "item 1",
                    "item 2"
                },
                Languages = new List<string>
                {
                    "rus tili",
                    "ingliz tili"
                }
            }
        };
        return employees;
    }
}
