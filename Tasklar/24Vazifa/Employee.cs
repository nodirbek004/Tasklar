using System.Data;

namespace Tasklar._24Vazifa;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Status status { get; set; }
    public Role role { get; set; }
    public DateTime? createdDate { get; set; } = null;
    public DateTime? updateDate { get; set; } = null;
    public DateTime? DeleteDate { get; set; } = null;
}
