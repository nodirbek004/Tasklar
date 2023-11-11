namespace Tasklar._26vazifa;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string? CreatedDate { get; set; }
    public string? UpdatedDate { get; set; }
    public string? DeletedDate { get; set; }

    public static Employee AddEmployee()
    {
        return new Employee
        {
            Name = "Nodir",
            Surname = "ollonazarov",
            Email = "nodir@gmail.com",
            Login = "user",
            Password = "nima"

        };
    }
}
