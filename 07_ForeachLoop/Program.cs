using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)
            // 1:Deüişken Türü
            //2:Değişken Adı
            //3:in
            //4:Koleksiyon,Liste,Dizi


            //string[] cities = { "Roma", "Londra", "İstanbul", "Madrid", "Istanbul" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 121, 54, 67, 83, 32, 56, 79, 81, 125 };
            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers = { 121, 54, 67, 83, 32, 56, 79, 81, 125 };
            //int total = 0;
            //foreach(int number in numbers)
            //{
            // total += number;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1,23,45,67,89,12,34,56,78,90
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string word = "Merhaaba";
            //foreach(char i in word)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
            #region Örnek Sınav Sitemi Uygulaması

            Console.WriteLine("***** Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alalım

            Console.WriteLine("------------------------------");
            Console.Write("Sınıftaki öğrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacağımız dizileri oluşturalım
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++) {

                Console.Write($"Lütfen {i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu alalım
                
                for(int j = 0; j<3; j++) {
                
                    Console.Write($"Lütfen {studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            //Sınav ortalamaları
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin  geçip kalma durumu 

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci  dersten geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("---------------");


            }










            #endregion
            Console.Read();
        }
    }
}
