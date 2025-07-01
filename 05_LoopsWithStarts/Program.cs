using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region alt alta on yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion


            #region yanyana on yıldız oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region alt alta on yıldız oluşturma her satırdaa 10 yıldız olsun

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region dik üçgen 
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region ters dik üçgen 

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region  üçgen 

            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                //yıldızlar
                for (int k = 1; k <= 2 * i -1; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
