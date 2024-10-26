using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_temel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            /// Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            /// Console.WriteLine();
            /// Console.WriteLine("1-Çorbalar");
            /// Console.WriteLine("2-Ana Yemekler");
            /// Console.WriteLine("3-Soğuk Başlangıçlar");
            /// Console.WriteLine("4-Salatalar");
            /// Console.WriteLine("5-Tatlılar");
            /// Console.WriteLine("6-İçecekler");
            /// Console.WriteLine();



            #endregion

            #region String Değişkenler

            //string customerName;
            //         string customerSurname;
            //         string customerEmail;
            //         string customerPhone, district, city;

            //         customerName = "Ali";
            //         customerSurname = "Çınar";
            //         customerEmail = "deneme@gmail.com";
            //         customerPhone = "+90 515165161";
            //         district = "Kadıköy";
            //         city = "İstanbul";

            //         Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------");

            //         customerName = "Ayşegül";
            //customerSurname = "Yılmaz";
            //customerEmail = "deneme2@gmail.com";
            //customerPhone = "+90 6265161";
            //district = "Sarıyer";
            //city = "İstanbul";

            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------");

            #endregion

            #region IntDegiskenler

            //int
            //int number = 2;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine();
            Console.WriteLine("*** RESTORAN MENU FIYATI ***");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("Kızartma: " + friesPrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("      *** ADİSYON ***");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            int totalhamburgerPrice = 0;
            int totalpizzaPrice = 0;
            int totalwaterPrice = 0;
            int totalcokePrice = 0;
            int totallemonadePrice = 0;
            int totalfriesPrice = 0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;



            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalfriesPrice = friesCount * friesPrice;
            totalPrice = totalcokePrice + totalfriesPrice + totalwaterPrice + totalhamburgerPrice + totallemonadePrice + totalpizzaPrice;

            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalpizzaPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalcokePrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalwaterPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TOPLAM TUTAR: >>>>  " + totalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("    **   Afiyet Olsun.  **    ");


            #endregion


            Console.Read();
        }
    }
}
