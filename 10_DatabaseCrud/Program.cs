using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ekleme işlemleri
            //string categoryName;
            //Console.Write("Lütfen Eklemek İstediğiniz ürünün adını girin : ");
            //categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data source = BARAN;initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Sorgu Başarı ile girildi");
            #endregion

            #region ürün ekleme işlemleri
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz ürünün adını giriniz : ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz ürünün fiyatını giriniz : ");
            //productPrice = decimal.Parse(Console.ReadLine());
            ////Console.Write("Eklemek İstediğiniz ürünün durumunu giriniz : ");
            ////productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = BARAN;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün EKLEMESİ Başarılı");


            #endregion

            #region ürün listeleme işlemleri

            //SqlConnection connection = new SqlConnection("Data source = BARAN;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}



            //connection.Close();

            #endregion

            #region silme işlemleri
            //Console.Write("Lütfen silmek istediğiniz numaarayı seçiniz : ");
            //int productId = Convert.ToInt32(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data source = BARAN;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi gerçekleştirildi");
            #endregion

            #region güncelleme işlemi

            Console.Write("Güncelleyeceğiniz kategoriyi ıd : ");
            int categoryId= Convert.ToInt32(Console.ReadLine());
            Console.Write("Güncelleyeceğiniz kategoriyi adı : ");
            string categoryName= Console.ReadLine();
            SqlConnection connection = new SqlConnection("Data source = BARAN;initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCategory set CategoryName=@p1 where CategoryId=@categoryId ", connection);
                command.Parameters.AddWithValue("@p1", categoryName);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.ExecuteNonQuery();

            


            connection.Close();
            Console.WriteLine("güncelleme tamam");

            #endregion







            Console.Read();
        }
    }
}
