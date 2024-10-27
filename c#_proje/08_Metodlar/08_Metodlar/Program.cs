﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar 
            //geri değer döndürmeyen metodlar
            //customer-listele, ekle, sil, güncelle
            // void 

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("merve yıldız");
            //    Console.WriteLine("yasemin yıldız");
            //    Console.WriteLine("suat yıldız");
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

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}
            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");




            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";

            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + "" + surname;

            //}
            //Console.WriteLine(StudentCard());

            #endregion


            #region Geriye Değer Döndüren Parametrei Metotlar 
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = " Ülke:" + countryName + " Başkent" + capital + " Bayrak rengi" + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz:");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-beyaz")); //birden fazla veriyi listeler

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}
            //Console.WriteLine(Sum(45, 89));
            //Console.WriteLine(Sum(41, 89));
            //Console.WriteLine(Sum(42, 89));
            //Console.WriteLine(Sum(25, 89));



            #endregion

            #region Örnek Uygulama 
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result>=50)
            //    {
            //        return student +  " Öğrenci sınavı geçti" + "Ortalama" + result;

            //    }
            //    else
            //    {

            //        return  student + " Öğrenci kaldı" + "Ortalama" + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 64, 64, 62));
            //Console.WriteLine(ExamResult("Begüm", 44, 74, 62));
            //Console.WriteLine(ExamResult("Sema", 30, 25, 14));

            #endregion 
            Console.Read();
        }
    }
}
