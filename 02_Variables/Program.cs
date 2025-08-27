using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler


            //double number;
            //number = 4.76;
            //Console.WriteLine(number);


            //Console.WriteLine("**** Fiyat Listesi ****");
            //double applePrice,orangePrice,patato,strawberryPrice,tomatoPrice;

            //applePrice = 15.83;
            //orangePrice = 12.25;
            //tomatoPrice = 8.45;
            //patato = 5.50;
            //strawberryPrice = 20.58;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("---Elma Birim Fiyatı: " + applePrice + " ₺");
            //Console.WriteLine("---Portakal Birim Fiyatı: " + orangePrice + " ₺");
            //Console.WriteLine("---Domates Birim Fiyatı: " + tomatoPrice + " ₺");
            //Console.WriteLine("---Patates Birim Fiyatı: " + patato + " ₺");
            //Console.WriteLine("---Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 0.768;
            //strawberryGram = 6.120;
            //patatoGram = 10.25;
            //tomatoGram = 3.972;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patato;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patato + " - Gramaj: " + patatoGram + " Toplam Tutar: " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + patatoTotalPrice + strawberryTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: "+shoppingTotalPrice+ "TL");
            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            //#endregion
            //#region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine(" ****  AYM Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");    
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "- Yolcu Ad Soyad:" + passengerName + " " +passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " +passengerAge);





            #endregion

            #region Klavyeden  Tam Sayı  Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + tvCount * tvPrice + chairCount * chairPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Toplam Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri   
            //double exam1, exam2,exam3, result;
            //Console.Write("1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3 Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınavların Ortalaması: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;

            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            #endregion
            Console.Read();
        }
    }
}
