using Tasklar._24Vazifa;

EmployeeWorks emp = new EmployeeWorks();
EmployeeWorks employeeWorks = new EmployeeWorks();
//emp.CreateTable();
//////////////////// bazaga malumot qoshish
//EmployeeBase employeeBase = new EmployeeBase();
//employeeBase = EmployeeMalumotlari.MalumotOLish();
//employeeWorks.Created(employeeBase);
//////////////////////// bazadan bir malumotni ochirish
//EmployeeDeleteCase employeeDeleteCase = new EmployeeDeleteCase();
//employeeDeleteCase = EmployeeMalumotlari.malumotniOlibTashlash();
//employeeWorks.Delete(employeeDeleteCase);
//////////////////////// bazadan hamma malumotni olish
//employeeWorks.GetAll();
///////////////////////// bazadagi barcha ma'lumotlarni o'chirish
//employeeWorks.DeepDelete();
////////////////////////// bazada malumotni yangilash
EmployeeBase employeeBase = new EmployeeBase();
employeeBase = EmployeeMalumotlari.MalumotOLish();
employeeWorks.Update(employeeBase);