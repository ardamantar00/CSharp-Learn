
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //console.writeline("selam");
            //console.write("merhaba dünya");

            //console.writeline("***** yemek kategorileri *****");
            //console.writeline();
            //console.writeline("1-çorbalar");
            //console.writeline("2-ana yemekler");
            //console.writeline("3-soğuk başlangıçlar");
            //console.writeline("4-salatalar");
            //console.writeline("5-tatlılar");
            //console.writeline("6-soğuk içecekler");
            //console.writeline();
            //console.writeline("***** yemek kategorileri *****");
            #endregion

            #region String Değişkenler
            //string
            //Değişken_türü değişken_adı;
            //string name;
            //name = "Arda";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ahmet";
            //customerSurname = "Yıldırım";
            //customerPhone = "+90 500 400 00 00";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName+ " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();
            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 400 10 10";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-posta: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");


            #endregion

            #region Int Değişkenler
            //Int
            //int number = 24;
            //Console.WriteLine(number);  
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---Kola: " + cokePrice + " TL");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount;
            int waterCount;
            int cokeCount;
            int friesCount;
            int lemondeCount;
            int pizzaCount;



            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalLemonadePrice = 0;
            int totalPizzaPrice = 0;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 2;
            lemondeCount = 0;


            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount; ;
            totalFriesPrice = friesPrice * friesCount;
            totalLemonadePrice = lemonadePrice * lemondeCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice);
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Limonata Tutarı " + totalLemonadePrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine();

            int totalPrice = totalFriesPrice + totalCokePrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");







            #endregion
            Console.Read();
        }
    }
}

//Yazdırma Komutları 