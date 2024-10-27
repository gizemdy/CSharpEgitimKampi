using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -- Create, read, update, delete

            #region  Kategori Ekleme işlemi


            //Console.WriteLine("****Menü Sipariş İşlem Paneli****");
            //Console.WriteLine("-----------------------------------")
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-N20QRR0\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName); //kategori ekleme işlemi
            //command.ExecuteNonQuery(); //sorguyu koşulsuz çalıştır
            //connection.Close();

            //Console.WriteLine("kategori başarıyla eklendi");

            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.WriteLine("****Menü Sipariş İşlem Paneli****");
            //Console.WriteLine("-----------------------------------");


            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-N20QRR0\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);    //bir sorgu oluştur!! //@p = parametre

            //command.Parameters.AddWithValue("@productName", productName);

            //command.Parameters.AddWithValue("@productPrice", productPrice);

            //command.Parameters.AddWithValue("@productStatus", true); //başlangıçta hepsini true ata

            //command.ExecuteNonQuery();  

            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı...");

            #endregion

            #region Ürün Listeleme işlemi


            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-N20QRR0\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command); //sqlden verileri c# tarafından çekecek bir köprü

            //DataTable dataTable = new DataTable();     //verileri geçici belleğe alabilmek için datatable sınıfına al

            //adapter.Fill(dataTable); //içini doldur

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();

            #endregion

            #region ürün silme işlemi 

            //Console.Write("Silinecek ürün ID giriniz: ");
            //int productId =int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-N20QRR0\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE From TblProduct where ProductId = @productId", connection);

            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();  



            //Console.WriteLine("Ürün silme işlemi başarılı...");

            //connection.Close();


            #endregion

            #region ürün güncelleme işlemi

            //Console.Write("Güncellenecek ürün ID giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatını giriniz: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());   




            //SqlConnection connection = new SqlConnection("Data Source= DESKTOP-N20QRR0\\SQLEXPRESS; initial catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId=@productId", connection); //ilki sqlden geliyor 2.si değişkenimiz

            //command.Parameters.AddWithValue("@productName", productName);

            //command.Parameters.AddWithValue("@productPrice", productPrice);

            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();

            //Console.WriteLine("Ürün güncelleme işlemi başarılı...");

            //connection.Close();


            #endregion

            Console.Read();
        }
    }
}
