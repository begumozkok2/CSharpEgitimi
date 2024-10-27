using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Main_Subject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları 
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***Yemek Kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-İçicekler");
            //Console.WriteLine("6-Tatlılar");
            //Console.WriteLine("***Yemek Kategorileri***");
            #endregion



            #region String Değişkenler 

            //string 
            //Değişken_türü değişken_adı 

            //string name;
            //name = "Murat";

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali ";
            //customerSurname = "Çınar ";
            //customerPhone = "+9053753573";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("***Rezervasyon Kartı***");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri" + customerName + " "+ customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("-------------------- ");

            //customerName = "Ayşegül ";
            //customerSurname = "Kaya";
            //customerPhone = "+90 657 47584 84";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Müşteri" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);
            //Console.WriteLine("-------------------- ");



            #endregion


            #region Int Değişkenler 
            //int 
            // int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 100;
            int lemonPrice = 30;

            Console.WriteLine("**Restron Menü Fiyatı***");
            Console.WriteLine();
            Console.WriteLine("--Hamburger Fiyatı: " + hamburgerPrice + " Tl");
            Console.WriteLine("--Kola: " + cokePrice + "TL");
            Console.WriteLine("--Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("--Limonata: " + lemonPrice);
            Console.WriteLine("--Kızartma: " + friesPrice);
            Console.WriteLine("--Su: " + waterPrice);
            Console.WriteLine();
            Console.WriteLine("**Restron Menü Fiyatı***");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;  
            int waterCount;
            int friesCount; 
            int pizzaCount; 
            int lemonCount;

            int totalHamburgerPrice = 0;    
            int totalCokePrice = 0;    
            int totalLemonPrice = 0;    
            int totalWaterPrice = 0;    
            int totalPizzaPrice = 0;    
            int totalFriesPrice = 0;    


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 4;
            friesCount = 4;
            pizzaCount = 4; 
            lemonCount = 1;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemonPrice = lemonCount * lemonPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            
            

            Console.WriteLine("---------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: "+ totalPizzaPrice + "TL");
            Console.WriteLine("Coke Tutarı: "+ totalCokePrice + "TL");
            Console.WriteLine("Lemon Tutarı: "+ totalLemonPrice + "TL");
            Console.WriteLine("Fries Tutarı: "+ totalFriesPrice + "TL");
            Console.WriteLine("Water Tutarı: "+ totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalLemonPrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");



            Console.Read();

#endregion


        }
    }
}
