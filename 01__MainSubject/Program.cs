using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Yazdırma Komutları

            ////Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion


            #region String Değişkenler

            //String 
            //Değişken_türü Değişken_adı;

            //string name;
            //name = "Melik";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Melik";
            //customerSurname = "Çevik";
            //customerPhone = "+90 538 556 40 69";
            //customerEmail = "Melik.cvk04@gmail.com";
            //district = "Sancaktepe";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("");


            //customerName = "Ceren Yasemin";
            //customerSurname = "Çevik";
            //customerPhone = "+90 535 250 20 41";
            //customerEmail = "Turgay.ceren@gmail.com";
            //district = "Sancaktepe";
            //city = "İstanbul";

            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------");

            #endregion




            #region İnt Değişkenler

            //İnt 

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int LemonadePrice = 30;


            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine("");
            Console.WriteLine("-----Hamgurger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + LemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL)");
            Console.WriteLine("-----su: " + waterPrice + " TL");
            Console.WriteLine("");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            Console.WriteLine("*************************************************");
            Console.WriteLine("");
            Console.WriteLine("---- Sipariş Özeti ----");
            Console.WriteLine("  Hamburger Tutarı= " + hamburgerCount * hamburgerPrice);
            Console.WriteLine("  Kola Tutarı= " + cokeCount * cokePrice);
            Console.WriteLine("  Su Tutarı= " + waterCount * waterPrice);
            Console.WriteLine("  Kızartma Tutarı= " + friesCount * friesPrice);
            Console.WriteLine("  Pizza Tutarı= " + pizzaCount * pizzaPrice);
            Console.WriteLine("  Limonata Tutarı= " + lemonadeCount * LemonadePrice);
            Console.WriteLine("+");
            Console.WriteLine("----------------------------------------");


            int totalprice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friesCount * friesPrice + pizzaCount * pizzaPrice + lemonadeCount * LemonadePrice;
            Console.WriteLine("Toplam Tutar = " + totalprice + " TL");







            #endregion




            Console.ReadKey();
        }
    }
}
