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
            //2,4,6,8...
            //adana, ankara, isstanbul, ...

            //******Degisken türü[] diziadi = new değişkentürü[elemansayisi]*****

            //string[] colors = new string[3];
            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "yellow";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "Paris";
            //cities[1] = "Budapeşte";
            //cities[2] = "Belgrad";
            //cities[3] = "Ankara";
            //cities[4] = "Adana";

            //Console.WriteLine(cities[3]);  

            //int[] numbers = new int[10];
            //numbers[0] = 91;
            //numbers[1] = 24;
            //numbers[2] = 31;
            //numbers[3] = 54;
            //numbers[4] = 51;
            //numbers[5] = 66;

            //Console.WriteLine(numbers[2]); 

            //string[] cities = { "prag", "ankara", "budapeste", "berlin" };

            //Console.WriteLine(cities[3]);  

            #endregion

            #region listeleme, sıralama 

            //dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "mavi", "kırmızı", "pembe", "yesil", "beyaz", "siyah" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 15, 14872, 656, 595, 360, 21, 20, 840, 54852, 122, 13, 89 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine("sayi: " + numbers[i]);
            //    }
            //}

            //****dizideki en büyük sayiyi bulan program***

            //int[] sayilar = { 6551, 8442, 3441, 4441, 4415, 9416, 4417, 2547};
            //int ebs = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > ebs)
            //    {
            //        ebs = sayilar[i];
            //    }

            //}
            //Console.WriteLine("en buyuk sayı:  " + ebs);
            //

            //int[] myArray = { 111, 632, 320, 564, 35, 68, 107, 648, 359, 170, 11 };
            //Array.Sort(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            #endregion

            #region Dizi Metodlar
            //string[] customers = { "Ali", "Buse", "Aslı", "evren", "mine", "salih", "derya" };
            //int index = Array.IndexOf(customers, "mine");
            //Console.WriteLine(index);

            //int[] numbers = { 2351, 221, 3641, 244, 155, 526, 751, 478 };

            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() + "  dizinin enk elemanı: " + numbers.Min());



            #endregion

            #region kullanıcıdan değerleri alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"lütfen {i+1}. değeri giriniz: ");
            //    cities[i] = Console.ReadLine(); 
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            int[] numbers = { 15, 22, 3, 34, 8, 2, 27, 4, 5 };
            //int total = 0;

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    total += numbers[i];

            //}

            //Console.WriteLine(total);

          

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 ==0)
                {
                    Console.WriteLine(numbers[i] + " --> cift");
                }
                else
                {
                    Console.WriteLine(numbers[i] + "--> tek");
                }
            }



            #endregion

            Console.Read();
        }
    }
}
