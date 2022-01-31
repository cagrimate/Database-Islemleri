using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProductCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            //ado.net connected mimari ile northwind database ine bağlanıp ürünler tablosunu getiriniz. birim fiyatı da para formatında gosterniz
            Console.OutputEncoding = Encoding.UTF8;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-B0E6NUI;Database=Northwind;User Id=sa;Password=1234;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select UrunAdi,BirimFiyati from Urunler";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["urunAdi"] + " | " + dr["birimFiyati"] + "₺| ");
            }
            //urunler tablosunu kategorileri ile getiriniz
            dr.Close();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "select k.KategoriAdi,u.UrunAdi from Urunler u join Kategoriler k on u.KategoriID=k.KategoriID";
            cmd2.Connection = con;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Console.WriteLine(dr2[0] + " | " + dr2[1]);
            }
            dr2.Close();
            con.Close();
            Console.ReadKey();


        }
    }
}
