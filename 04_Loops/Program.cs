using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Atatürk");
            //}
            //for (int i = 1; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ne yazmak istiyorsun : ");
            //string veri = Console.ReadLine();
            //Console.Write("ne kadar yazdırmak istiyorsun : ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i+".değer "+veri);
            //}

            #endregion

            #region for döngüsü ile kara yapıları
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue=0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalvalue += i;


            //}
            //Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue = totalValue + i;
            //        Console.WriteLine(i);
            //    }


            //}
            //Console.WriteLine(totalValue);

            //int bacterium = 1;
            //for (int i = 0; i <= 24; i++)
            //{
            //    bacterium = bacterium * 2;
            //    Console.WriteLine(i+".saat sonunda oluşan bakteri sayısı : "+bacterium);
            //}


            #endregion

            #region while döngüsü

            //int yazdir = 1;
            //while (yazdir<=10)
            //{
            //    Console.WriteLine("merhaba while");
            //    yazdir++;

            //}


            //int i = 1;
            //while (i <= 10) 
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i); 

            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;

            //    i++;

            //}
            //Console.WriteLine(sum);



            #endregion

            #region örnek sınav sorusu

            //kullanıcıdan veriyi al sonra sayıyı basamaklarına ayır ve sonar her ayırdığın basamakları topla

            //Console.Write("Sayınızı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds,sum;
            //ones = sayi % 10;
            //tens = (sayi % 100)/10;
            //hundreds = (sayi / 100);
            //sum = ones+tens+hundreds;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
