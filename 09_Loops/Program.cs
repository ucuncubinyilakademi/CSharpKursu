using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Döngüler tekrar eden kod bloklarını tekrar tekrar yazmaktan bizi kurtarır. Belli bir tekrar(tur) sayısı belirlenir ve turun her adımında yapılacak işlem tanımlanır.

            WHILE, FOR, DO WHILE, FOREACH
             
             */

            //Ekrana 1 ile 10 arasındaki sayıları alt alta yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            #region WHILE

            #region 1.Örnek
            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region 2.Örnek

            // 1 ile 100 arasındaki 3'ün katları olan sayıları ekrana yazdırınız.

            //int s = 3;

            //while (s < 100)
            //{
            //    Console.WriteLine(s);
            //    s += 3; //s=s+3;
            //}

            //------------------------------------

            //int s = 1;
            //while (s < 100)
            //{
            //    if (s % 3 == 0)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    s++;
            //}
            #endregion

            #region 3.Örnek

            //1-100 arasındaki sayılardan 3'ün katları olanların toplamını ekrana yazdırınız.

            //int s = 1;
            //int toplam = 0;
            //while (s < 100)
            //{
            //    if (s % 3 == 0)
            //    {
            //        toplam = toplam + s;
            //    }

            //    s++;
            //}
            //Console.WriteLine("Toplam:" + toplam);
            #endregion

            #region 4.Örnek

            // Kullanıcıya kaç adet ürün aldığını soralım. Girilen adet kadar kullanıcıya fiyat girmesini isteyelim ve toplam ödemesini ekrana yazdıralım.

            //Console.WriteLine("Kaç adet ürün aldınız:");
            //int adet = Convert.ToInt32(Console.ReadLine()); //5

            //int s = 1;
            //int toplam = 0;
            //while (s <= adet)
            //{
            //    Console.WriteLine("Fiyat Gir");
            //    int fiyat = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyat;
            //    s++;
            //}
            //Console.WriteLine("Toplam:" + toplam);



            //Console.WriteLine("Kaç adet ürün aldınız:");
            //int adet = Convert.ToInt32(Console.ReadLine()); //5

            //double toplam = 0;
            //while (0 < adet)
            //{
            //    Console.WriteLine("Fiyat Gir");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    toplam += fiyat;
            //    adet--;
            //}
            //Console.WriteLine("Toplam:" + toplam);


            #endregion

            #region 5.Örnek Kullanıcı Girişi

            //BREAK: break komutu kendi içinde bulunduğu döngüyü kırar(bitirir).

            // 3 giriş hakkı vererek kullanıcıadı ve şifre alıp giriş kontrolü yazınız

            //string admin = "altanemre";
            //string sifre = "1";
            //int hak = 3;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Username:");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Password:");
            //    string password = Console.ReadLine();

            //    if (username == admin && sifre == password)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }               
            //    else
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz");
            //    }
            //    hak--;
            //    Console.WriteLine("Kalan Hakkınız:" + hak);
            //}

            /*
            string dogruKullaniciAdi = "admin";            string dogruSifre = "123";            int girishakki = 3;            while (girishakki > 0)            {                Console.WriteLine("KullanıcıAdı:");                string KullaniciAdi = Console.ReadLine();                Console.WriteLine("Şifre:");                string sifre = Console.ReadLine();                if (KullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
                {                    Console.WriteLine("Giriş başarılı");                    break;
                }                else
                {                    Console.WriteLine("Giriş Başarısız! Kalan Giriş Hakkı: " + girishakki);                }                girishakki--;                Console.WriteLine("kalan hakknı:" + girishakki);                if (girishakki == 0)
                {                    Console.WriteLine("Giriş hakkınız Bitti");                }

            */




            #endregion

            #region 6.Örnek

            //Continue: bulunduğu satırdan döngü koşuluna geri döner.

            /*
            //int i = 1;

            //while (i<10)
            //{
            //    if (i == 7)
            //    {
            //        //i++;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            */


            // Kullanıcıdan 5 adet tek sayı alıp ekrana yazdırınız.

            //int i = 1;
            //while (i < 6) 
            //{
            //    Console.WriteLine("Tek sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine()); // 1,2

            //    if (sayi % 2 == 1)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //    i++;
            //}

            #endregion

            #region 7.Örnek

            //while (true)
            //{
            //    Console.WriteLine("Altan Emre HARİKA BİR ÖĞRETMENDİR. İNŞALLAH DAHA DA ZENGİN OLUR");
            //    break;
            //}


            // Kullanıcı 0 değerini girene kadar girilen bütün sayıları toplayan döngü yapısını kodlayınız.
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}

            //Console.WriteLine("Toplam:"+toplam);


            #endregion


            #region RANDOM

            //while (true)
            //{
            //    Random r = new Random();

            //    int sayi = r.Next(1, 100);

            //    Console.WriteLine(sayi);
            //}


            // Bilgisayar 1 100 arasında bir rastgele değer tutsun ve kullanıcının 5 hak da tahmin etmesini isteyin. tahminleri büyültün küçültün gibi yönlendirin.

            // Random r = new Random();
            // int rastgele = r.Next(1, 100);
            //// Console.WriteLine(rastgele);
            // int hak = 1;
            // while (hak<6) // 5,4,3,2,1
            // {
            //     Console.WriteLine("Tahmininiz:");
            //     int tahmin = Convert.ToInt32(Console.ReadLine());

            //     if (tahmin == rastgele)
            //     {
            //         Console.WriteLine("Tebrikler");
            //         break;
            //     }
            //     else if (hak == 5)
            //         Console.WriteLine("Hakkınız Bitti.");
            //     else if (tahmin > rastgele)
            //         Console.WriteLine("Tahmininizi Küçültünüz");
            //     else
            //         Console.WriteLine("Tahmininizi Büyültünüz.");
            //     hak++;
            // }

            #endregion

            #endregion

            #region FOR 

            //int i = 0;

            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
            for(sayaç,koşul,step)
            {
                //iŞLEM
            
            }
            
             
             
             */

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);                
            //}

            #region 1.Örnek

            // For loop ile 1 - 100 arasındaki çift sayıları yazdırınız

            //for (int i = 1; i < 100; i++)
            //{
            //    if(i%2==0)
            //        Console.WriteLine(i);
            //}


            #endregion

            #region 2.Örnek

            // For loop ile 1 - 100 arasında 3'ün katı sayıların adetini ve toplamını yazdırınız


            //int toplam=0;
            //int adet = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        toplam += i;
            //        adet++;
            //    }

            //}
            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Adet:"+adet);


            #endregion

            #region 3.Örnek
            // 5 => 1*2*3*4*5 =>

            //kullanıcıdan alınacak bir sayının faktöriyelini bulan hesaplamayı  for ile yapınız
            //int faktoriyel = 1;
            //Console.WriteLine("Faktöriyel hesaplanacak sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <=sayi; i++)
            //{
            //    faktoriyel *= i;
            //}

            //Console.WriteLine("Sonuç:"+faktoriyel);

            #endregion

            #endregion

            #region DO_WHILE

            //do
            //{
            //    //işlem
            //} while (//koşul);

            #region 1.Örnek

            //Kullanıcı 0 girene kadar girilen sayıların toplamını ekrana yazdırın

            int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //        break;

            //    toplam += sayi;
            //}

            int sayi = 0;
            do
            {
                Console.WriteLine("Sayı:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            } while (sayi!=0);



            Console.WriteLine("Toplam="+toplam);



            #endregion



            #endregion





            Console.ReadLine();
        }
    }
}
