using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_databaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine(" ***** C# Veritabanlı Ürün-Kategori Bilgi Sistemi ***** ");
            Console.WriteLine();
            Console.WriteLine();

            string tableNo;

            Console.WriteLine("---------------------");           
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            Console.WriteLine("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNo=Console.ReadLine();
            Console.WriteLine("---------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N20QRR0\\SQLEXPRESS;initial Catalog=EgitimKampi;integrated security=true");
            
            connection.Open();
            
            SqlCommand command = new SqlCommand("Select*From TblCategory",connection);
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataTable dataTable = new DataTable();
            
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
    

            Console.Read();
        }
    }
}
