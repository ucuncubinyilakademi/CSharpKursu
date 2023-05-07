using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VeriTipleri_Degiskenler
{
    internal class Program
    {
        //public enum Brand { Mercedes,BMW,Opel,TOGG}
        //enum: Belirli değerler kümesini temsil eden bir türdür.
        static void Main(string[] args)
        {
          /* ************** DEĞİŞKENLER (Variables)**************
             Yazılım içerisinde data tanımlamak, datayı işleme tabi tutarak sonucunu tutmak,data taşımak vb işlemler için tanımlama yapmamızı sağlar yapılardır.

            *** DEĞİŞKEN TANIMLAMA ***
            
            veritipi değişkenadı = değer;

            ** ÖNEMLİ
                * Değişken isimleri kendi bulundukları { } içerisinde benzersiz olmalıdır.
                * İsimlendirme Kuralları (case-Sensitive)
                    * yanlışlar: 5sayi, ?sayi, sayi!, ad soyad, 
                    * doğrular:  sayi5, _sayi, sayi_, adsoyad, ad_soyad
                    * alt tire bütün yazılım dillerinde geçerli tek özel karakterdir.
             */
            //İki farklı değer tutmak için
            //int yas1 = 11;
            //int yas2 = 34;

            // TAnımlı sayı değeri değiştirmek için
            //int sayi = 5;
            //sayi = 10;

            // ** Küçük BÜYÜK harf duyarlılığı olduğu için iki farklı değişken isimlendirmesi oldu 
            //int yas = 12;
            //int Yas = 13;


            /* 
              **************** VERİ TİPLERİ (Data Types) ****************
             * SAYISAL VERİ TİPLERİ (int,long,double)
            ** int: +/- 10 basamağa kadar tam sayıları tanımlar.

            // İki Kardeş yaşını toplayınız.
            int yas = 33;

            Console.WriteLine(yas);
            Console.WriteLine(yas+5);

            int yas2 = 12;

            int toplam = yas + yas2;


            ** long: +/-10 basamak üstündeki tam sayıları tanımlar;
            long tc = 12345678909;

            ** float : +/- Ondalık sayıları tanımlar.Float değer sonuna 'f' işareti konulur.
            float sayi = 12.5f;

            ** double: +/- Ondalık sayıları tanımlar. Floatdan daha büyük sayıları tutabilir.
            double sayi = 12.5;


            ** decimal: her Sayı tipini tanımlar.
            decimal sayi = 12.511111111111111122233444m;


            * SÖZEL VERİ TİPİ(char,string)
            ** char: karakter tipidir. Tek karakter tutar.  ' tek tırnak ile tanımlanır.
                char h = '2';
                char f = ';';
                char s = 'A';

            ** string: Metin veri tipidir. Sınırsız uzunluğa sahiptir ve " " ile tanımlanır.
                string ad = "Altan Emre";
                string soyad = "Demirci";


            * MANTIKSAL VERİ TİPİ(Boolean)
            ** bool: Sadece true veya false değerleri alır.


             */

            //bool cevap = true;
            //bool cevap2 = false;

            ////bool sonuc = 5 < 3;
            ////bool sonuc = 5 == 3;
            ////bool sonuc = 5 != 3; //! =
            //bool sonuc = (5+3)==8;

            //Console.WriteLine(sonuc);


            // '+' sayısal veritiplerinde TOPLAMA, sözel veri tiplerinde BİRLEŞTİRME yapar.

            //int s1 = 12;
            //int s2 = 13;

            //-----------

            //string s1 = "12";
            //string s2 = "13";

            //-----------

            //string s1 = "12";
            //int s2 = 13;

            //Console.WriteLine(s1+s2);

            //{
            //    int a;
            //    {
            //        int b;
            //    }
            //    a = 10;//Geçerli
            //    b= 5;  //Hata
            //}

            //int a;
            //{
            //    int a; //HATA
            //    {
            //        long a; //HATA
            //    }
            //}


            //{
            //    {
            //        long a = 2;
            //    }
            //    {
            //        int a = 2;
            //    }

            //}

            //Sabit Değişken anlamına gelir. değer ilk tanımdan sonra değiştirilemez.
            //const int pi = 3;

            //pi = 4;


            // Değişken Tanımlama Şekilleri
            int a;
            a = 5;


            int b, c;
            b = 3;
            c = 4;


            int d = 3, e = 5;


            //int sayi,string ad; // HATA: Aynı satırda 2 farklı veritipine sahip değişken tanımlana 


            Console.ReadKey();  
            //Console.ReadLine();

           

            
        }
    }
}
