using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i=1;i<=5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı: ");


            //}

            //for(i=1;int<=20;int++)
            //{
            //    Console.WriteLine(i);

            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i=1; i<=finishValue;i++ )
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");

            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları 
            //for(int i=0;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalvalue = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    totalvalue += i;

            //}
            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for(int i=1;i<=20;i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);

            //    }
            //}

            //Console.WriteLine(totalvalue);

            // int count = 0;

            //for(int i=1;i<=50;i++)
            // {
            //     if(i%7==0)
            //     {
            //         count++;

            //     }
            // }
            // Console.WriteLine(count);


            //1-2-4-8-16 saatte 2 ye bölünen Bakteri 24 saat sonunda kaç bakteri

            //int bacterium = 1;
            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);            }




            #endregion


            #region While Döngüsü
            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0)
            //    {


            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //int i = 1;
            //int totalvalue=0;

            //while(i<=10)
            //{
            //    totalvalue += i;
            //    i++;
            //}
            //Console.WriteLine(totalvalue);






            #endregion


            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamkaları toplamını yazınız
          
            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundred = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundred);

            //sum = ones + tens + hundred;

            //Console.WriteLine(sum);



            #endregion


            Console.Read();
        }
    }
}
