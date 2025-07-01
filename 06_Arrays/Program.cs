using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  temel dizi örnekleri

            //string[] colors = new string[4];

            //colors[0] = "mavi";
            //colors[1] = "sarı";
            //colors[2] = "kırmızı";
            //colors[3] = "beyaz";

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //string[] city = { "ankara", "istanbul" };
            //Console.Write(city[1]);



            #endregion

            #region dizideki tüm elemanları listeleme
            //int[] dizi = new int[3];
            //dizi[0] = 1;
            //dizi[1] = 2;
            //dizi[2] = 3;

            //for (int i = 0; i < dizi.Length; i++) { Console.WriteLine(dizi[i]); }

            //int[] dizi = { 1, 2, 3, 4, 5, 7, 8, 6, 15, 14, 13, 12, 11 };
            //int maxnumber = dizi[0];
            //for (int i = 0; i < dizi.Length; i++) 
            //{
            //    if (dizi[i]>maxnumber)
            //    {
            //        maxnumber = dizi[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);

            //int[] numbers = { 1, 2, 5, 6, 12, 24, 1, 4, 6, 7, 56 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 1, 2, 5, 6, 12, 24, 1, 4, 6, 7, 56 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] dizi = new string[5];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.ci şehri giriniz : ");
            //    dizi[i] = Console.ReadLine();
            //}
            //for (int i = 0;i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}


            //int[] dizi = new int[5];
            //dizi[0] = 1;
            //dizi[1] = 2;
            //dizi[2] = 3;
            //dizi[3] = 4;
            //dizi[4] = 5;
            //int sum = 0;
            //for (int i = 0; i < dizi.Length; i++) 
            //{ 
            //    sum += dizi[i]; 

            //}
            //Console.WriteLine(sum);


            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]%2==0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }


            #endregion

            Console.Read();


        }
    }
}
