using System.Data.SqlClient;

namespace Tasklar._25Vazifa;

public class Database
{
    public static void GetAll(string TableName, string DatabaseName, string ColumnName)
    {
        using (SqlConnection connect = new SqlConnection($"Server=(localdb)\\MSSQLLocalDB;Database={DatabaseName};Trusted_Connection=True;"))
        {
            connect.Open();

            string query = $"select {ColumnName} from {TableName} ";

            SqlCommand sqlCommand = new SqlCommand(query, connect);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                int count = reader.FieldCount;
                var read = reader.GetColumnSchema().Select(x => x.ColumnName);


                List<Models> list = new List<Models>();
                int i = 1;
                reader.Read();

                while (i > 0)
                {
                    list.Add(new Models
                    {
                        FirstName = reader[0].ToString()
                    });
                    list.ForEach(x => Console.WriteLine(x.FirstName));
                    // Console.Write($"Col{j} {reader[j]} \t");
                    i--;
                }
            }
        }
    }
    public static void Insert(string DatabaseName, string TableName, List<Models> models)
    {
        using (SqlConnection connect = new SqlConnection($"Server=(localdb)\\MSSQLLocalDB;Database={DatabaseName};Trusted_Connection=True;"))
        {
            connect.Open();

            var model = models[0];
            string query = $"insert into {TableName} (Name,LastName,Quantity) Values ('{model.FirstName}','{model.LastName}','{model.Quantity}');";

            SqlCommand sqlCommand = new SqlCommand(query, connect);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
