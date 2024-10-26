using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //for(i=0; i<20; i+=2)
            //{
            //    i += i;
            //}
            //Console.WriteLine(i);

            //int count = 0;
            //for (i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("1 ile 50 arasında " + count + " adet bolunen vardır.");
            #endregion

            #region bakteri örneği

            //int bakteri = 1;
            //int saat;

            //// başta 1 - 2 -4 -8- 16...
            //// 24 saatin sonunda kaç bakteri olur

            //for(saat = 1; saat<=24; saat++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(saat + ". saatin sonunda bakteri sayısı: "+ bakteri);
            //}



            #endregion

            #region while

            //int i = 1;
            //int sum = 0;

            //while (i < 10)
            //{
            //    sum += i;
            //    i++;
            //    Console.WriteLine(sum);
            //}

            #endregion

            #region örnek sınav sorusu

            //klavyeden girilen 3 bas sayının bas say top?

            Console.WriteLine("3 basamaklı bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int birler;
            int onlar;
            int yuzler;

            yuzler = sayi / 100;
            birler = sayi % 10;
            onlar = (sayi / 10)%10;

            Console.WriteLine("sayının yüzler basamağı: " + yuzler);
            Console.WriteLine("sayının onlar basamağı: " + onlar);
            Console.WriteLine("sayının birler basamağı: " + birler);


            #endregion





            Console.Read();

        }
    }
}
