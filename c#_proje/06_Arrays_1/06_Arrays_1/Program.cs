using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri 
            //2,4,6,8
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "turuncu";
            //colors[3] = "pembe";

            //Console.WriteLine(colors[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 24;

            //Console.WriteLine(numbers[0]);

            //string[] cities = { "Prag", "Roma", "Atina" }; //sayı belirtmeden bu şekilde yapılabilir. 
            //Console.WriteLine(cities[0]);


            #endregion


            #region Dizi Tüm Elemanları listeleme 
            //string[] colors = { "sarı", "mavi", "turuncu" };

            //for(int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = {4,20,30,90,78};

            //for (int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'v' };
            //for (int i=0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 48, 89, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

            //int maxNumber = myArray[0];

            //for(int i =0; i< myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];

            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "veli", "begüm" };
            //Console.WriteLine(persons.Length);



            //int[] numbers = { 45, 67, 89, 53, 78, 39 };
            //Array.Sort(numbers); //küçükten büyüğe sıralama 
            //for(int i =0; i<numbers.Length; i++ )
            //{
            //    Console.WriteLine(numbers[i]);

            //}


            //int[] numbers = { 45, 67, 89, 53, 78, 39 };
            //Array.Reverse(numbers); //diziyi komple tersten sıralıyor 
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}
            #endregion

            #region Dizi Metotlar 
            //string[] customers = { "ali", "merve", "çınar", "kaya" };

            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 6, 5, 7, 535, 64, 35, 2, 5 };
            //Console.WriteLine("Dizinin En büyük elemanı:" + numbers.Max() + "Dizinin en küçük elemanı " + numbers.Min());
            #endregion


            #region Kullanıcıdan Değer alma 

            //string[] cities = new string[5];

            //for(int i = 0; i<cities.Length;i++)
            //{ 
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------");

            //for (int i = 0;i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);

            //}

            //int[] numbers = {10,20, 30};
            //int sum = 0;
            // for (int i=0; i<numbers.Length; i++ )
            //{
            //    sum += numbers[i];
            //}
            // Console.WriteLine(sum);


            //int[] numbers = {1, 2, 3, 4, 5, 6, 7};
            //Console.WriteLine("Çift Sayılar: ");
            //for (int i=0; i<numbers.Length; i ++)
            //{
            //    if (numbers[i]  % 2 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //Console.WriteLine("Tek Sayılar: ");
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 !=0 )
            //    { 
            //        Console.WriteLine(numbers[i]);
            //    }
            //}










            #endregion




            Console.Read();


        }
    }
}
