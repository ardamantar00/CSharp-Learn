using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Değişken Türü [] DiziAdı = new DeğişkenTürü[ElemanSayısı];

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Turuncu";
            //colors[3] = "Sarı";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Bursa";
            //cities[4] = "Antalya";

            //Console.WriteLine(cities[5]);

            //int [] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[7] = 414;
            //numbers[9] = 123;
            //Console.WriteLine(numbers[2]);

            //string[] cities = {"İstanbul","Ankara","İzmir","Bursa","Antalya"
            //};
            //Console.WriteLine(cities[3]);

            #endregion
            #region Dizideki Tüm elemanları Listleleme
            //string[] colors = { "Kırmızı", "Mavi", "Turuncu", "Sarı","Pembe","Siyah","Lila","Beyaz"};

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]); 
            //}

            //int[] numbers = { 1, 121, 56, 67, 87, 66, 44, 1460, 1352, 788, 900 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //char[] symbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //for(int i = 0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 1, 121, 56, 67, 87, 66, 44, 1460, 1352, 788, 900,1214,54,89,12,19 };

            //int maxNumber  = numbers[0];

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük sayı: " + maxNumber);

            //string[] persons = { "Ahmet", "Mehmet", "İsmet", "Saffet", "Canan", "Ceyda", "Bahar", "Ece", "Zeynep", "Yasemin", "Deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 121, 56, 67, 87, 66, 44, 1460, 1352, 788, 900, 1214, 54, 89, 12, 19 };
            //Array.Sort(numbers);

            //for(int i = 0; i< numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 12, 56, 77, 3, 5, 90, 76, 51, 13, 80, 44, 41, 66, 21, 83 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion
            #region Dizi Metotları
            //string[] customers = { "Ahmet", "Mehmet", "İsmet", "Saffet", "Canan", "Ceyda", "Bahar", "Ece", "Zeynep", "Yasemin", "Deniz" };
            //int index = Array.IndexOf(customers, "İsmet");

            //Console.WriteLine(index);

            //int[] numbers = { 45, 27, 79, 124, 25, 68, 73, 19, 11 };

            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " En küçük elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[4];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------");


            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 12, 24, 36, 10, 4 };
            //int sum = 0;

            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine("Dizideki sayıların toplamı: " + sum);

            int[] numbers = {115,24,35,42,51,60,73,84,91,10 };
            Console.WriteLine("Çift sayılar");
            Console.WriteLine("------------");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("------------");
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
           
        }
    }
}
