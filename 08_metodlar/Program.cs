using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region metodlar
            //Geriye değer dondurmeyen metodlar
            //(void)
            // customer ---> listele, guncelle....

            //void customerList()
            //{
            //    Console.WriteLine("ayse");
            //    Console.WriteLine("ali");
            //    Console.WriteLine("murat");
            //    Console.WriteLine("mehmet");
            //}

            //customerList(); //yazmazsak üstteki yazılanlar ekrana gelmez!!!! (çağırmak için)
            //void Sum()
            //{
            //    int x = 5;
            //    int y = 55;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();  // çağır (yani ekrana çıktıları getir)

            #endregion

            #region geriye değer döndürmeyen String parametreli metodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("müşteri:" + name + " soyadı:" +surName);
            //}
            //CustomerCard("ahmet", "tok");

            #endregion

            #region geriye deger dondurmeyen int parametreli metodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("sayiların toplamı: " + result);
            //}
            //Sum(1, 5, 95);
            #endregion

            #region geriye deger DONDUREN metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region geriye deger DONDUREN str parametreli metotlar

            //string CountryCard(string countryname, string capital, string flagColor)
            //{
            //    string cardInfo ="Ülke: -" + countryname + "başkent: -" + capital + "bayrak: -" + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;

            //Console.Write("ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("baskent adını giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak renklerini giriniz: ");
            //z = Console.ReadLine();


            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye - ", "Ankara - ", "KIRMIZI-BEYAZ"));

            #endregion

            #region geriye deger DONDUREN int metotlar

            //int Sum(int num1, int num2)
            //{
            //   int result  = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(56, 11));
            //Console.WriteLine(Sum(93, 02));
            //Console.WriteLine(Sum(45, 36));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3)/3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci  **" + result + "**  ortalamayla  >> GEÇTİ >> ";
                }
                else
                {
                    return student + " isimli öğrenci  **"+ result + "**  ortalamayla ||| KALDI |||";
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(ExamResult("Ayşe Kaya", 45,35,64));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Ali Yılmaz", 89, 85, 94));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Derya Ekin", 48, 32, 55));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Dicle Aydın", 87, 71, 90));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Hüseyin Alıcı", 42, 51, 49));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Zeynep Okur", 75, 40, 64));
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(".....................işlem tamamlandı....................");


            #endregion

            Console.Read();
        }
    }
}
