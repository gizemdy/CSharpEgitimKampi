using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variabless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            #region DOUBLE

            //Console.WriteLine(" **** FİYAT LİSTESİ *** ");
            //         Console.WriteLine();

            //         double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //         applePrice = 14.85;
            //         orangePrice = 20.95;
            //         strawberryPrice = 45;
            //         potatoPrice = 9.74;
            //         tomatoPrice = 6.88;

            //         Console.WriteLine("---- Elma birim fiyatı:  " + applePrice + " TL");
            //Console.WriteLine("---- Portakal birim fiyatı:  " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek birim fiyatı:  " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates birim fiyatı:  " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates birim fiyatı:  " + tomatoPrice + " TL");
            //         Console.WriteLine();
            //         Console.WriteLine();

            //double appleGram, potatoGram, tomatoGram, strawberryGram, orangeGram;

            //         appleGram = 1.245;
            //         orangeGram = 2.650;
            //         strawberryGram = 0.75;
            //         potatoGram = 4.859;
            //         tomatoGram = 3.745;

            //         double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, tomatoTotalPrice, potatoTotalPrice, totalPrice;

            //         appleTotalPrice = appleGram * applePrice;
            //         orangeTotalPrice = orangeGram * orangePrice;
            //         strawberryTotalPrice = strawberryGram * strawberryPrice;
            //         tomatoTotalPrice = tomatoGram * tomatoPrice;
            //         potatoTotalPrice = potatoGram * potatoPrice;
            //         totalPrice = tomatoTotalPrice + potatoTotalPrice + strawberryTotalPrice + orangeTotalPrice + appleTotalPrice;

            //         Console.WriteLine("Alınan ürün: Elma -  " + "Birim fiyatı: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal -  " + "Birim fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek -  " + "Birim fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates -  " + "Birim fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates -  " + "Birim fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            //         Console.WriteLine();
            //Console.WriteLine();
            //         Console.WriteLine("TOPLAM TUTAR   >>>  " + totalPrice + " TL");

            #endregion

            #region KLAVYEDEN GİRİŞLE STR DEGİSKENLER

            //Console.WriteLine("CSharp Hava Yolları Yolcu Bilgileri");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdNo;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge =Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passengerIdNo =Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------------------------------------");

            //Console.WriteLine("Yolcu TC No: " + passengerIdNo + " Yolcu Ad-Soyad: " + passengerName+passengerSurname + " Yolcu Yaşı: " + passengerAge + 
            //	" İl/İlçe: " + passengerCity + "/" + passengerDistrict);

            //Console.WriteLine("-----------------------------------------------------------------------------------");



            #endregion

            #region KLAVYEDEN TAMSAYI GİRİŞİ VE DONUSUMLER

            //int shoesPrice, pcPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //pcPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, pcCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız pc sayısını giriniz: ");
            //pcCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + pcPrice * pcCount + tvPrice * tvCount + chairCount * chairPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar:   >>> " + totalPrice);

            #endregion
            #region Klavyeden Ondalıklı Sayı Girişi

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:  " + result);


            #endregion

            #region KLAVYEDEN KARAKTER GİRİLMESİ

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion




            Console.Read();

        }
    }
}
