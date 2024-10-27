using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWhiteStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta yıldızz oluşturma
            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}




            #endregion

            #region Yan yana alt alta yıldızz oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}




            #endregion

            #region Alt alta her satırında 10 tane yıldız olması 

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("************");
            //}




            #endregion


            #region Dik üçgen 
            //for (int i = 1; i <= 5; i++)
            //{
            //   for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Ters Dik Üçgen 

            //for (int i = 5; i>=1;i--)
            //{
            //    for(int j=1; j<=i;j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}


            #endregion

            #region Dik ve Ters üçgen beraber
            //for(int i=1; i<=5; i++)
            // {
            //     for(int j=1;j<=i;j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();

            // }
            //for(int k=4;k>=1;k--)
            // {
            //     for(int m=1; m<=k;m++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();

            // }
            #endregion

            #region piramit
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for(int j=n-i;j>0;j--)
                {
                    Console.Write(" ");

                }
                for(int k=1; k<=2*i;k++)
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