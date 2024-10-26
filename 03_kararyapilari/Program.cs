using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_kararyapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("ülkeyi giriniz:  ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı..");
            //} 
            //else
            //{
            //    Console.Write("hatalı bilgi..");
            //}

            //int sayi;
            //Console.Write("Sayıyı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı...");
            //}
            #endregion

            #region Klavyeden Sayı Girişi ve ortlama hesaplama

            //int exam1, exam2, exam3, average;
            //string result = " ";

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());
            //if ((exam1 | exam2 | exam3)<0)
            //{
            //    Console.Write("hatalı sayı girişi..");
            //}
            //else { 

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:  " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuc kötü";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70 & average <=84)
            //{
            //    result = "sonuc iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "başarılı";
            //}
            //}
            //Console.WriteLine(result);


            #endregion

            #region city


            //string city;

            //Console.Write("Lütfen şehir giriniz: ");

            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil..");
            //}

            #endregion

            #region kull. adı
            //Console.Write("Lütfen kullanıcı adını giriniz: ");

            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("hatalı kullanıcı adı..");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}


            #endregion

            #region Mod işlm

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bolumunden kalan: " + result);

            //Console.Write("lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number%2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{

            //    Console.WriteLine("sayı tektir");
            //}

            #endregion

            #region team
            //char team;
            //Console.Write("Lütfen takım sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team =='g'| team == 'G')
            //{
            //    Console.Write("galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FENERBAHÇE");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("tirabzonsipor");
            //}

            #endregion

            #region restoran 

            //Console.WriteLine("**** RESTORAN ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Lutfen kategori seçimi yapınız: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") {
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-------");
            //    Console.WriteLine();
            //    Console.WriteLine("ana yemek 1");
            //    Console.WriteLine("ana yemek 2");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("çorba 1");
            //    Console.WriteLine("çorba 2");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("pizza 1");
            //    Console.WriteLine("pizza 2");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-------");
            //    Console.WriteLine();
            //    Console.WriteLine("drink 1");
            //    Console.WriteLine("drink 2");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("tatlı 1");
            //    Console.WriteLine("tatlı 2");
            //}



            #endregion

            #region switch case

            //    Console.WriteLine("lütfen 1-12 arası giriş yapınız: ");
            //    int month = int.Parse(Console.ReadLine());

            //    switch(month)
            //    {
            //        case 1: Console.Write("Ocak");break;
            //        case 2: Console.Write("Şubat"); break;
            //        case 3: Console.Write("Mart"); break;
            //        case 4: Console.Write("Nisan"); break;
            //        case 5: Console.Write("Mayıs"); break;
            //        case 6: Console.Write("Haziran"); break;
            //        case 7: Console.Write("Temmuz"); break;
            //        case 8: Console.Write("Ağustos"); break;
            //        case 9: Console.Write("Eylül"); break;
            //        case 10: Console.Write("Ekim"); break;
            //        case 11: Console.Write("Kasm"); break;
            //        case 12: Console.Write("Aralık"); break;
            //        default: Console.WriteLine("hatalı giriş");break;
            //}


            #endregion

            #region hesap makinası
            int sayi1, sayi2;
            char islem;

            Console.WriteLine("1. sayıyı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("yapmak istediğiniz işlem operatörünü giriniz: ");
            islem = char.Parse(Console.ReadLine());

            switch (islem)
            {
                case '+': Console.Write(sayi1+ sayi2);break;
                case '-': Console.Write(sayi1 - sayi2); break;
                case '/': Console.Write(sayi1 / sayi2); break;
                case '*': Console.Write(sayi1 * sayi2); break;
                default : Console.Write("hatalı işlem"); break;
            }


            #endregion

            Console.Read();
        }
    }
}
