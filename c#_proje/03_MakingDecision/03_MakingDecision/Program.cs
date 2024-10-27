using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If 

            //Console.Write("Lütfen şifreyi giriniz:");
            //String password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");

            //}
            //Console.Read();

            //int number;
            //Console.Write("Sayıyı giriniz");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int okul_number;
            //Console.Write("okul numaranızı giriniz:");
            //okul_number = int.Parse(Console.ReadLine());
            //if(okul_number==17931)
            //{
            //    Console.WriteLine("Okul Numaranız doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Okul Numaranız Yanlış Tekrar deneyiniz");
            //}


            //int exam1, exam2, exam3, average;
            //string result=" hata";

            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması:" + average);

            //if(average>0 & average<50)
            //{
            //    result = " sonuç vasat";

            //}
            //if(average>50 & average<=70)
            //{
            //    result = " sonuç orta";
            //}
            //if(average>70 & average>=84)
            //{
            //    result = " sonuç iyi";

            //}
            //if(average>84)
            //{
            //    result = " sonuç çok iyi ";
            //}
            //Console.WriteLine(result);
            {
                //    string city;
                //    Console.Write("Lütfen şehir girişi yapınız: ");
                //    city = Console.ReadLine();

                //    if (city == "adana"  | city == "ankara" | city == "bursa" |  city == "trabzon")



                //{
                //        Console.WriteLine("şehir mevcut");
                // }
                //else
                //    {
                //        Console.WriteLine("şehir mevcut değil");
                //    }
                //}














                //Console.ReadLine();

                #endregion


                #region
                //int number;
                //number = 26;
                //int result = number % 5;
                //Console.WriteLine(result);

                //Console.ReadLine();

                //char team;
                //Console.Write("Lütfen takım sembolünü giriniz: ");
                //team = char.Parse(Console.ReadLine());

                //if(team == 'g' | team == 'G')
                //{
                //    Console.Write("Galatasaray");

                //}
                //if(team == 'f' | team == 'F')
                //{
                //    Console.Write("Fenerbahçe");

                //}
                //if(team=='b' | team == 'B')
                //{
                //    Console.Write("Beşiktaş");

                //}





                #endregion


                #region Örnek Proje uygulaması 
                //Console.WriteLine("c# eğitim kampı restron****");
                //Console.WriteLine();
                //Console.WriteLine("--------------");
                //Console.WriteLine("1-ana yemekler");
                //Console.WriteLine("2-ana yemekler");
                //Console.WriteLine("3-ana yemekler");
                //Console.WriteLine("4-ana yemekler");
                //Console.WriteLine("5-ana yemekler");
                //Console.WriteLine("--------------");


                //string menuItem;
                //Console.Write("Lütfen detayını görmek istediğiniz menü seçimi: ");
                //menuItem = Console.ReadLine(); 

                //if (menuItem=="1")
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("------ana yemekler------");
                //    Console.WriteLine();
                //    Console.WriteLine("1-Köri Soslu tavuk");
                //     Console.WriteLine("2-Kırzatma");
                //     Console.WriteLine("3-fasulye");
                //     Console.WriteLine("4-pilav");
                //     Console.WriteLine("5-patlıcan");
                //    Console.WriteLine("----ana yemekler----");

                //    Console.WriteLine();


                //}

                //if (menuItem == "2")
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("------çorbalar------");
                //    Console.WriteLine();
                //    Console.WriteLine("1-mercimek");
                //    Console.WriteLine("2-ezogelin");

                //    Console.WriteLine("----çorbalar----");

                //    Console.WriteLine();


                //}

                //if (menuItem == "3")
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("------pizzalar------");
                //    Console.WriteLine();
                //    Console.WriteLine("1-margarita");
                //    Console.WriteLine("2-bolmazemos");
                //    Console.WriteLine("3-vejeteryan");

                //    Console.WriteLine("----çorbalar----");

                //    Console.WriteLine();


                //}
                //if (menuItem == "4")
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("------içecekler------");
                //    Console.WriteLine();
                //    Console.WriteLine("1-kola");
                //    Console.WriteLine("2-ayran");
                //    Console.WriteLine("3-fanta");
                //    Console.WriteLine("4-su");
                //    Console.WriteLine("5-soda");
                //    Console.WriteLine("----içecekler----");

                //    Console.WriteLine();


                //}

                //if (menuItem == "5")
                //{
                //    Console.WriteLine();
                //    Console.WriteLine("------tatlılar-----");
                //    Console.WriteLine();
                //    Console.WriteLine("1-kazandibi");
                //    Console.WriteLine("2-muhallebi");
                //    Console.WriteLine("3-künefe");
                //    Console.WriteLine("4-katmer");
                //    Console.WriteLine("5-chescake");
                //    Console.WriteLine("----ana yemekler----");

                //    Console.WriteLine();


                //}


                #endregion


                #region switch case 

                //Console.Write("Lütfen ay girişi yapınız: ");
                //int monthNumber = int.Parse(Console.ReadLine());
                //switch (monthNumber)
                //{

                //    case 1:Console.Write("Ocak");break;
                //    case 2:Console.Write("Şubat");break;
                //    case 3:Console.Write("Mart");break;
                //    case 4:Console.Write("Nisan");break;
                //    case 5:Console.Write("Mayıs");break;
                //    case 6: Console.Write("Haziran"); break;
                //    case 7: Console.Write("Temmuz"); break;
                //    case 8: Console.Write("Ağustos"); break;
                //    case 9: Console.Write("Eylül"); break;
                //    case 10: Console.Write("Ekim"); break;
                //    case 11: Console.Write("Kasım"); break;
                //    case 12: Console.Write("Aralık"); break;
                //    default:Console.Write("Hatalı Veri Girişi");break;


                //}

                #endregion

                #region switch case hesap makinesi 

                //int number1, number2, result;
                //char symbol;

                //Console.Write("1.sayıyı giriniz: ");
                //number1=int.Parse(Console.ReadLine());

                //Console.Write("2.sayıyı giriniz: ");
                //number2=int.Parse(Console.ReadLine());

                //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz");
                //symbol=char.Parse(Console.ReadLine());




                //switch(symbol)
                //{
                //    case '+':
                //        result = number1 + number2;
                //        Console.WriteLine("Toplam:" + result);
                //        break;


                //    case '-':
                //        result = number1 - number2;
                //        Console.WriteLine("Fark:" + result);
                //        break;


                //    case '*':
                //        result = number1 * number2;
                //        Console.WriteLine("Çarpım:" + result);
                //        break;


                //    case '/':
                //        result = number1 / number2;
                //        Console.WriteLine("Bölüm:" + result);
                //        break;




                }







                #endregion





                Console.Read();

            }
        }
    }
