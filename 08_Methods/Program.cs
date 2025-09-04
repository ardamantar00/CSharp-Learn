using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye değer döndürmeyen metotlar void olarak tanımlanır.
            //Customer -> Ekle,Sil,Güncelle,Listele
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmet Doğan");
            //    Console.WriteLine("Suat Kaya");
            //    Console.WriteLine("Mehmet Yılmaz");
            //    Console.WriteLine("Ayşe Demir");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x + y;
            //    Console.WriteLine("Toplam: " + z);

            //}
            //Sum();






            #endregion
            #region Geriye Değer Döndürmeyen string parametreli  Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Müşteri Adı: " + customerName);
            //}
            //WriteMethod("Ahmet Doğan");

            //void CustomerCard(string name, string surnName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surnName);
            //}
            //CustomerCard("Barış", "Yılmaz");

            #endregion
            #region Geriye Değer Döndürmeyen Int parametreli  Metotlar
            //void Sum(int num1,int num2,int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string customerName()
            //{
            //    return "Suat Doğan";
            //}

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yılmaz";

            //    return name + " " + surname;
            //}

            //Console.Write(studentCard());

            #endregion
            #region Geriye Değer Döndüren  String Parametreli Metotlar


            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;

            //Console.Write("Ülke adı: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent adı: ");
            //y = Console.ReadLine();


            //Console.Write("Bayrak rengi: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));

            //Console.WriteLine(countryCard("Türkiye","Ankara","Kırmızı - Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,54));
            //Console.WriteLine(Sum(100, 250));
            //Console.WriteLine(Sum(22, 33));

            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " Sınıfı Geçti Ortalama : " + result;
            //    }
            //    else
            //    {
            //        return student + " Sınıfta kaldı Ortalama : " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ahmet Doğan", 0, 56, 20));
            //Console.WriteLine(ExamResult("Cem Uçar", 100, 50, 74));

            #endregion
            Console.Read();

        }
    }
}