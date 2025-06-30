using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double değişkenler
            double number = 0.34;
            Console.WriteLine(number);
            #endregion

            #region char değişkenler
            char harf = 'a';
            Console.WriteLine(harf);

            #endregion

            #region klavyeden veri girişi
            Console.Write("isminiz nedir = ");
            string putName = Console.ReadLine();
            Console.Write("soyisminiz nedir = ");
            string putSurname = Console.ReadLine();

            Console.WriteLine("İsim soyisim : " + putName + " " + putSurname);

            #endregion

            #region klavyaden tam sayı girişleri ve dönüşümler
            int shoesPrice;
            shoesPrice = 1000;
            int shoesCount;
            Console.Write("kaç ayakkabı aldın : ");
            shoesCount = int.Parse(Console.ReadLine());
            int totalPrice = shoesCount * shoesPrice;
            Console.Write("toplam ödeyeceğin ücret : " + totalPrice + " tl");


            #endregion

            #region klavyeden ondalıklı sayı girme
            double exam1, exam2, result;
            Console.Write("exam1  = ");
            exam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("exam2  = ");
            exam2 = Convert.ToDouble(Console.ReadLine());
      

           
                result = (exam1 % 40) + (exam2 % 60);
                Console.Write(result);
            
          
            

            Console.Read();
        }




        #endregion
    }

}
            
