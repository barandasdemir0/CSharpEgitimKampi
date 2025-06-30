using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region yazdırma komutları  (print commands)
            //Console.Write("hello world");   --> write yazmak
            //Console.WriteLine("selam"); --> writeline yazma satırı
            #endregion

            #region string değişkenler (variable)

            //string name;
            //name = "baran";
            //Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;


            //camelcase customerName   district = semt

            customerName = "baran";
            customerSurname = "daşdemir";
            customerPhone = "05554442233";
            customerEmail = "denemeler@example.com";
            district = "keçiören";
            city = "ankara";


            Console.WriteLine(customerName+" "+customerSurname + " " + customerPhone + " " + customerEmail + " " + district + " " + city);


            #endregion

            #region int değişkenler  integer = tam sayı  price = ücret
            int sayi= 25;
            Console.WriteLine(sayi);

            #endregion

            Console.Read();

        }
    }
}
