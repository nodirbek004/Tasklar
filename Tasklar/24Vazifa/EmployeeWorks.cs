using System.Data.SqlClient;

namespace Tasklar._24Vazifa;

public class EmployeeWorks : IEmployeeCrud
{
    public void CreateTable()
    {
        SqlConnection con = new SqlConnection(@"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;");
        string query = $"Create table employee" +
            $" (id int  IDENTITY(1,1) NOT NULL," +
            $"FirstName varchar(50)," +
            $"LastName varchar(50)," +
            $"Email varchar(50)," +
            $"Login varchar(50)," +
            $"password varchar(50)," +
            $"status int," +
            $"role varchar(50)," +
            $"createdDate varchar(30)," +
            $"updatedDate varchar(30)," +
            $"deletedDate varchar(30));";

        SqlCommand cmd = new SqlCommand(query, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created Successfully");
        }
        catch (SqlException e)
        {
            Console.WriteLine("Bu table bor edi yoki ma'lumotlar noto'g'ri kiritilgan");
        }
        finally
        {
            con.Close();
            Console.ReadKey();
        }

    }

    public void Created(EmployeeBase employee)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();
            //
            string query = $"insert into employee" +
                $"(firstname,lastname,email,login,password,status,role," +
                $"createdDate,updatedDate,deletedDate) " +
                $"values('{employee.FirstName}'," +
                $"'{employee.LastName}','{employee.Email}','{employee.Login}'," +
                $"'{employee.Password}',{1},'{employee.role}'," +
                $"'{employee.createdDate}','{employee.updateDate}','{employee.DeleteDate}')";

            SqlCommand sqlcommand = new SqlCommand(query, connect);
            int rowsAffected = sqlcommand.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Qo'shildi");
            else
                Console.WriteLine("Qo'shilmadi");
        }
    }

    public void DeepDelete()
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();
            string query = $"update employee set status=2,deletedDate='{DateTime.Now}' where status!=2";
            SqlCommand sqlcommand = new SqlCommand(query, connect);
        }
    }

    public void Delete(EmployeeDeleteCase employee)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();
            string query = $"update employee set status=2,deletedDate='{DateTime.Now}' " +
                $"where FirstName = '{employee.FirstName}' and " +
                $"LastName = '{employee.LastName}' and " +
                $"Email = '{employee.Email}' and " +
                $"Login = '{employee.Login}' and status!=2 ";
            SqlCommand sqlcommand = new SqlCommand(query, connect);
            int rowsAffected = sqlcommand.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("O'chirildi");
            else
                Console.WriteLine("Bu oldin o'chirilgan");
        }

    }

    public void GetAll()
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();

            string query = "select * from employee where status != 2 ";
            SqlCommand sqlcommand = new SqlCommand(query, connect);
            using (SqlDataReader reader = sqlcommand.ExecuteReader())
            {

                while (reader.Read())
                {
                    Console.WriteLine(reader[1]);
                }
            }
        }
    }

    public void GetByName(Employee employee, string Name)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();

            string query = $"select * from employee where status != 2 and FirstName = {Name} ";
            SqlCommand sqlcommand = new SqlCommand(query, connect);
            using (SqlDataReader reader = sqlcommand.ExecuteReader())
            {

                while (reader.Read())
                {
                    Console.WriteLine(reader[1]);
                }
            }
        }
    }

    public void Update(EmployeeBase employee)
    {
        using (SqlConnection connect = new SqlConnection())
        {
            connect.ConnectionString = @"Server = DESKTOP-HUHB6EP; Database = Birinchi_ish; Trusted_Connection=true;";
            connect.Open();
            string query = $"update employee set " +
                $"firstname = '{employee.FirstName}',lastname= '{employee.LastName}',email = '{employee.Email}'," +
                $"login= '{employee.Login}',password = '{employee.Password}',status=3,role='{employee.role}'," +
                $"updatedDate='{DateTime.Now}' " +
                $"where password='{employee.Password}' and login = '{employee.Login}' and email ='{employee.Email}' and status!=2;";

            SqlCommand sqlcommand = new SqlCommand(query, connect);
            int Updatemi = sqlcommand.ExecuteNonQuery();
            if (Updatemi > 0)
            {
                Console.WriteLine("Yangilandi");
            }
            else
            {
                Console.WriteLine("Xatolik! Yangilanmadi");
            }
        }

    }
}
