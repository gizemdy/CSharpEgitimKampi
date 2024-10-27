using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach dongusu
            // 1. degisken turu
            //2. degisken adi
            //3. in
            // liste,koleksiyon, dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "edirne", "kars" };

            //foreach(string i in cities)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 81, 25, 43, 24, 35 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 81, 25, 43, 24, 35, 82, 69, 83, 96};
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //int[] numbers = { 81, 25, 43, 24, 35, 82, 69, 83, 96 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3,4
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba!";
            //foreach (char i in word)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region sınav uygulaması
           

            Console.Write("**** CSharp Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //ogr say kullanıcıdan alma
            Console.WriteLine("---------------------------");

            Console.Write("sınıfınızda kaç öğrenci var: ");

            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            // not ort saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)

            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");

                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //her öğrenci için 3 sınav girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. notu: ");

                    double value = int.Parse(Console.ReadLine());

                    totalExamResult += value; 
                }

                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i = 0; i < studentCount; i++) 

            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine($" {studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");
                
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"  {studentNames[i]} isimli öğrenci geçti. ");
                }
                else
                {
                    Console.WriteLine($"  {studentNames[i]} isimli öğrenci kaldı. ");
                }

                Console.WriteLine("----------------------------------");
            }


            #endregion


            Console.Read();
        }
    }
}
