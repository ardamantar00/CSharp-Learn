using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string passsword = Console.ReadLine();
            //if(passsword == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = " Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <=84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if(average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir ismini giriniz: ");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "bursa"  | city == "gaziantep")
            //{
            //    Console.WriteLine("Girdiğiniz şehir Türkiye'de var");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kulllanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}


            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 121;
            //int result = number % 2;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{ 
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;

            //Console.Write("Takımın baş harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Takım Beşiktaş");
            //}
            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Takım Galatasaray");
            //}
            //if(team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Takım Fenerbahçe");
            //}
            //if(team == 't' || team == 'T')
            //{
            //    Console.WriteLine("Takım Trabzonspor");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** AYM Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Ana Yemekler ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Adana kebap");
            //    Console.WriteLine("2-Tavuk");
            //    Console.WriteLine("3-Balık");
            //    Console.WriteLine("4-Patlıcan Musakkka");
            //    Console.WriteLine("5-Köfte");
            //    Console.WriteLine("--------------- Ana Yemekler ---------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çorbalar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Kremalı Mantar Çorbası");
            //    Console.WriteLine("4-Domates Çorbası");
            //    Console.WriteLine("--------------- Çorbalar ---------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Sucuklu Pizza");
            //    Console.WriteLine("4-Karışık Pizza");
            //    Console.WriteLine("--------------- Pizzalar ---------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Soda");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine("5-Çay");
            //    Console.WriteLine("6-Kahve");
            //    Console.WriteLine("--------------- İçecekler ---------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------- Tatlılar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Kadayıf");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- Kazandibi");
            //    Console.WriteLine("5- Profiterol");
            //    Console.WriteLine("6- Cheesecake");
            //    Console.WriteLine("7- Tiramisu");
            //    Console.WriteLine("8- Künefe");
            //    Console.WriteLine("9- Dondurma");
            //    Console.WriteLine("10- Trileçe");
            //    Console.WriteLine("--------------- Tatlılar ---------------");
            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ay giriş yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak ayındasınız"); break;
            //    case 2: Console.WriteLine("Şubat ayındasınız"); break;
            //    case 3: Console.WriteLine("Mart ayındasınız"); break;
            //    case 4: Console.WriteLine("Nisan ayındasınız"); break;
            //    case 5: Console.WriteLine("Mayıs ayındasınız"); break;
            //    case 6: Console.WriteLine("Haziran ayındasınız"); break;
            //    case 7: Console.WriteLine("Temmuz ayındasınız"); break;
            //    case 8: Console.WriteLine("Ağustos ayındasınız"); break;
            //    case 9: Console.WriteLine("Eylül ayındasınız"); break;
            //    case 10: Console.WriteLine("Ekim ayındasınız"); break;
            //    case 11: Console.WriteLine("Kasım ayındasınız"); break;
            //    case 12: Console.WriteLine("Aralık ayındasınız"); break;

            //    default: Console.WriteLine("Hatalı ay numarası girdiniz");
            //        break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1.sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak İstediğiniz işlemi seçin: ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case  '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1/ number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default:
                    Console.WriteLine("Hatalı işlem seçtiniz");
                    break;
            }
            #endregion


            Console.Read();
        }
    }
}
