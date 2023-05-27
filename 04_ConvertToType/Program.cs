using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConvertToType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            * Bilinçli Tür Dönüşümü
            * Bilinçsiz Tür Dönüşümü
            * Boxing
            * Unboxing            
            */

            //BİLİNÇSİZ TÜR DÖNÜŞÜMÜ
            //int sayi = 1;
            //decimal sayi2 = sayi;


            //BOXING-BilinçliTürDönüşümü
            //decimal sayi = 1;
            //int sayi2 = (int)sayi;


            //BİLİNÇLİ TÜR DÖNÜŞÜMÜ

            //string sayi = "5";
            //short sayi2 = Convert.ToInt16(sayi);
            //int sayi3 = Convert.ToInt32(sayi);
            //long sayi4 = Convert.ToInt64(sayi);

            //string sayi = 5;
            //int s = int.Parse(sayi);
            //short s2 = short.Parse(sayi);


            // İki kardeşin yaşlarını kullanıcıdan alıp toplamını ekrana yazdıralım.

            /*
            Console.WriteLine("1.kardeşin yaşı:");
            string yas = Console.ReadLine();

            int age = Convert.ToInt32(yas);

            Console.WriteLine("2.kardeşin yaşı:");  
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:"+(age+age2));
            */


            // Sayısal veritipinden sözel veri tipine(string) dönüşüm için iki yöntem var

            //**1. Yol
            //int sayi = 5;
            //string s = Convert.ToString(sayi);

            //**2. Yol
            //int sayi = 5;
            //string s2 = sayi.ToString();



            //INDEXOF
            //string yazi = "altan emre demirci";
            //Console.WriteLine(yazi.IndexOf("e"));

            //TRIM
            //Console.WriteLine("       altan".Trim());
            //Console.WriteLine("       altan".TrimEnd());
            //Console.Write("altan     ".Trim());
            //Console.Write("altan     ".TrimStart());

            //Console.WriteLine("altan".Trim('a'));


            //TOUPPER() and TOLOWER()
            // ********* YAZILIM DİLLERİNİN HEPSİNDE BÜYÜK HARF KÜÇÜK HARF DUYARLILIĞI VARDIR ********
            //string username = "altanemre";
            //Console.WriteLine("Username:");
            //string kullaniciadi = Console.ReadLine();

            //Console.WriteLine(kullaniciadi.ToLower()==username);


            //SUBSTRING()
            //** Index: string değerlerin 0 dan başlayarak her karakterinin numaralandırılmasına denir.
            //string metin = "bu ders bir başka ders";
            //string metin2 = metin.Substring(2);
            //string metin3 = metin.Substring(5);

            //Console.WriteLine(metin2);



            Console.WriteLine("yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(yas+10);

            Console.ReadLine();
        }
    }
}
