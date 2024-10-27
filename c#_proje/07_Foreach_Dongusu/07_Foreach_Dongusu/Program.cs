using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü 

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste Koleksiyon,Dizi 

            //string[] cities = { "milano", "roma ", "budapeşte", "ankara" };

            //foreach(string x in cities) // foreach in fordan farkı başlangıç bitiş kendi ayarlar 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {45,54,434,432,435,5,6,7,8,9,10,11,12,13,14,15,16,}

            //foreach (int number in numbers)
            //{
            //    if (numbers % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 54, 434, 432, 435, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };

            //int total = 0;

            //foreach(int i in numbers )
            //{
            //    total += i; 
            //}
            //Console.WriteLine( total ); 

            //List<int> numbers = new List<int>()
            //{
            //    1,2,4,5,6,7,8
            //};


            //foreach(int number in numbers ) //listelerde çalışır foreach 
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach(char c in word )
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması 

            Console.WriteLine("*************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Sınıfınızda kaç öğrenci var ");
            int studentCount =int.Parse(Console.ReadLine());

            //Öğrenci isimlerini ve not ortalamalrını saklıyacaka diziler
            string[] studentNames = new string[studentCount];
            double[] stduentExamAvg = new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();



                double totalExamResult = 0;



                //Her öğrenci için 3 sınav notu girişi 

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz


                }
              
                stduentExamAvg[i] = totalExamResult/3;


            }

            //sınav ortalamaları

            for(int i=0; i< studentCount; i++)
            {
                Console.WriteLine($"{ studentNames[i]} adlı öğrencinin ortalaması: {stduentExamAvg[i]} ");

                if (stduentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");                }


            }




















            Console.ReadLine();





            #endregion



        }
    }
}
