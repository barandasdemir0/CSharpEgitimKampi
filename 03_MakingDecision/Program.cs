using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if 
            //Console.Write("Lütfen Şifrenizi giriniz");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifreniz doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifreniz yanlış");
            //}
            //Console.Read();

            //string country, capital;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (country=="türkiye"&&capital=="ankara")
            //{;
            //    Console.Write("veriler doğru");
            //}
            //else
            //{
            //    Console.Write("veriler yanlış");   
            //}

            //double exam1,exam2,result;

            //Console.Write("1.sınav sonucu : ");
            //exam1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sınav sonucu : ");
            //exam2 = Convert.ToInt32(Console.ReadLine());
            //result = (exam1 * 0.4) + (exam2 * 0.6);
            //if (result>=50)
            //{
            //    Console.Write("Büte kalmadın");
            //}
            //else
            //{
            //    Console.Write("büt dayanır kapıya");
            //}

            //Console.Write("Kullanıcı adı giriniz : ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Kullanıcı giriş yapamaz");
            //}
            //else
            //{
            //    Console.Write("kullanıcı giriş yapar");
            //}






            #endregion

            #region mod işlemleri
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Sayıyı gir bea : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Kaçla modunu alalım : ");
            //int mod = int.Parse(Console.ReadLine());
            //int result = number % mod;
            //Console.Write("Sonuç : "+result);

            #endregion

            #region switch case

            //Console.Write("Ay girişi yapınız : ");
            //int mountNumber = int.Parse(Console.ReadLine());

            //switch(mountNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralıl"); break;
            //    default: Console.Write("Ay bulunamadı"); break;
            //}

            #endregion

            #region hesap makinesi

            Console.Write("1.sayıyı giriniz : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            int number2 = int.Parse(Console.ReadLine());
            int result;
            Console.Write("Yapmak istediğiniz işlem : ");
            char symbol = char.Parse( Console.ReadLine());

            switch(symbol)
            {
                case '+': 
                    result= number1 + number2;
                    Console.Write("Sonucumuz : " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("Sonucumuz : " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("Sonucumuz : " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write("Sonucumuz : " + result);
                    break;
            }

            #endregion  

            Console.Read();

        }
    }
}
