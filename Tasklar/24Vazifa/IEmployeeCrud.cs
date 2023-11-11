namespace Tasklar._24Vazifa;

public interface IEmployeeCrud
{
    void Created(EmployeeBase employee);
    void Update(EmployeeBase employee);
    void Delete(EmployeeDeleteCase employee);
    void DeepDelete();
    void GetAll();
    void GetByName(Employee employee, string Name);
}
