namespace Tasklar._24Vazifa;

public class EmployeeMalumotlari
{
    public static EmployeeBase MalumotOLish()
    {
        List<string> ishlar = new List<string>()
                {

                    "Admin",
                    "Programmer",
                    "Officeer",
                    "Cleaner",
                    "Recruiter",
                    "Manager",
                    "CEO",
                    "CoFounder",
                    "Founder",
                    "GlavniyDirector",
                    "Security",
                    "other"
                };
        EmployeeBase emp = new EmployeeBase();
        Console.Write("Ismingizni kiriting = ");
        emp.FirstName = Console.ReadLine();
        Console.Write("Familiyangizni kiriting = ");
        emp.LastName = Console.ReadLine();
        Console.Write("Emailingizni kiriting = ");
        emp.Email = Console.ReadLine();
        Console.Write("Login kiriting = ");
        emp.Login = Console.ReadLine();
        Console.Write("Parolingizni kiriting = ");
        emp.Password = Console.ReadLine();
        emp.status = 1
       ;
        for (int i = 0; i < ishlar.Count; i++) Console.WriteLine($"{i + 1} {ishlar[i]}");
        Console.Write("Ishingiz(son) = ");
        emp.role = Console.ReadLine();
        emp.createdDate = DateTime.Now;
        emp.updateDate = null;
        emp.DeleteDate = null;
        return emp;
    }
    public static EmployeeDeleteCase malumotniOlibTashlash()
    {
        EmployeeDeleteCase emp = new EmployeeDeleteCase();
        Console.Write("Ismingizni kiriting = ");
        emp.FirstName = Console.ReadLine();
        Console.Write("Familiyangizni kiriting = ");
        emp.LastName = Console.ReadLine();
        Console.Write("Emailingizni kiriting = ");
        emp.Email = Console.ReadLine();
        Console.Write("Loginni kiriting = ");
        emp.Login = Console.ReadLine();

        return emp;
    }
}
