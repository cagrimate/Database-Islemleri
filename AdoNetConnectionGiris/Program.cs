using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConnectionGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-B0E6NUI;Database=Chinook;User Id=sa;Password=1234;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select top 50 t.Name,t.Composer,t.Milliseconds, g.Name from Track t join genre g on  g.GenreId=t.GenreId where Milliseconds>400000";
            cmd.Connection = con;
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]+" | " +dr[1] +" | " +dr[2] +" | " +dr[3] +" | " );
            }
            con.Close();
            Console.ReadKey();


        }
    }
}
