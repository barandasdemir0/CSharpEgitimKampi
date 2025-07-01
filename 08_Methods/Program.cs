using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void methodlar


            //void CustomerList()
            //{
            //    Console.WriteLine("baran daşdemir");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region geriye değer döndürmeyen parametreli metodlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Baran");


            #endregion

            #region geriye değer döndüren metotlar

            //string NameCard()
            //{
            //    string name = "baran";
            //    string surname = "daşdemir";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(NameCard());

            #endregion


            #region  geriye değer döndüren parametreli metotlar

            //string countryCard(string countryName,string capital)
            //{
            //    string cardInfo = countryName + " " + capital;
            //    return cardInfo;
            //}
            //Console.WriteLine(countryCard("Türkiye","Ankara"));


            int examresult (int exam1,in int exam2)
            {
               int result = (exam1 + exam2) / 2;
                if (result>=50)
                {
                    Console.Write("Harikasın lan it : ");
                }
                return result;
            }

            int sexam1, sexam2;
            Console.Write("1.sınav Sonucu Gir : ");
            sexam1 = int.Parse(Console.ReadLine());
            Console.Write("2.sınav Sonucu Gir : ");
            sexam2 = int.Parse(Console.ReadLine());

            Console.WriteLine(examresult(sexam1 , sexam2));




            #endregion



            Console.Read();

        }
    }
}
