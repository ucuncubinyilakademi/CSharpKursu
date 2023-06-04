using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Arrays_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aşağıdaki Şekilleri for ile ayrı ayrı oluşturunuz.

            /*
             
            *
            **
            ***
            ****
            *****
            ******
            *******
           */

            //for (int i = 1; i <= 13; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /*
            *******
            ******
            *****
            ****
            ***
            **
            *
            
            */
            //for (int i = 13; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}



            /*


                *
               ***
              *****
             *******
            *********
           ***********
           
             */

            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 7 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int x = 8;
            //for (int i = 1; i <= x; i++)
            //{
            //    for (int j = 1; j <= (x - i); j++)
            //        Console.Write(" ");

            //    for (int t = 1; t < i * 2; t++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}


            #endregion

            #region adınızın harflerini for döngüsü ile alt alta sıralayın 

            //string ad = "AltanEmre"; // string aslında char'lar oluşan bir dizidir. string => char[]
            //string[] isim = { "A", "l", "t","a","n" };

            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            #endregion

            #region kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak ve sonrasında her bir ürün adı yazılarak karşısında fiyatı istendikten sonra bütün ürünlerin isimleri karşısında fiyatlarını listeleyiniz
            //Console.WriteLine("kaç adet ürün gireceksiniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string[] urun_adi = new string[sayi];
            //int[] urun_fiyatı = new int[sayi];

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine((i + 1) + ". ürünün adının giriniz");
            //    urun_adi[i] = Console.ReadLine();
            //    Console.WriteLine((i + 1) + ". ürünün fiyatınnı giriniz");
            //    urun_fiyatı[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine(urun_adi[i] + " " + urun_fiyatı[i]);                
            //}



            //Console.Write("Kaç adet ürün gireceksiniz? ");
            //int urunSayisi = int.Parse(Console.ReadLine());

            //string[] urunIsimleri = new string[urunSayisi];
            //decimal[] urunFiyatlari = new decimal[urunSayisi];

            //for (int i = 0; i < urunSayisi; i++)
            //{
            //    Console.Write($"Ürün {i + 1} adı: ");
            //    urunIsimleri[i] = Console.ReadLine();

            //    Console.Write($"Ürün {i + 1} fiyatı: ");
            //    urunFiyatlari[i] = decimal.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"Ürünlerin Listesi ve Fiyatları:");

            //decimal toplamFiyat = 0;
            //for (int i = 0; i < urunSayisi; i++)
            //{
            //    toplamFiyat += urunFiyatlari[i];
            //}

            //Console.WriteLine($"Toplam Fiyat: {toplamFiyat}₺");
            #endregion

            #region Aşağıdaki dizideki tekrar eden dataların indexleri ekrana yazdırınız.

            string[] isimler = { "Ali", "Veli", "Ali", "Ahmet", "Mehmet", "Ali", "Zehra", "Fatma", "Ayşe", "Ali" };

            #region Ali Güner
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    int a = Array.IndexOf(isimler, isimler[i]);

            //    if (a != i)
            //    {
            //        Console.WriteLine(isimler[a]);
            //    }
            //}
            #endregion

            int uzunluk = isimler.Length;

            int indx = -1;

            while (true)
            {
                if (indx >= uzunluk-1)
                    break;
                indx = Array.IndexOf(isimler, "Ali",indx+1);
                Console.WriteLine(indx);
            }
            
            
            #endregion
           
            Console.ReadKey();

        }
    }
}
