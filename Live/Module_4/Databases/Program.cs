using Microsoft.Data.SqlClient;

namespace Databases;

internal class Program
{
    static void Main(string[] args)
    {
        using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProductCatalog;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True"))
        using (SqlCommand cmd = new SqlCommand())
        {
            con.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM Core.Products";
            cmd.Connection = con;
            var res = cmd.ExecuteScalar();
            Console.WriteLine(res);
        }
       // con.Dispose();
       // Console.WriteLine(con.State);


    }
}
