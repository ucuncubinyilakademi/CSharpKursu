using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;

            // Çoklu data tutma ihtiyacında Collections kullanılır.

            /*
             ****** ARRAY ******
             Array eleman sayısı belirtilen birden fazla aynı vertipinde değerleri tutan koleksiyon yapısıdır. Array [] işaretleri ile tanımlanır.
            Array index adı verilen numaralandırma yöntemi ile aldığı her değere numara verir. Index 0 dan başlar.
             */

            //Boş Array Tanımı
            //int[] sayilar = new int[5]; //max 5 int değer alabilir.
            //Array Eleman Ekleme
            //sayilar[0] = 1;
            //sayilar[1] = 12;
            //sayilar[2] = 14;
            //sayilar[3] = 11;
            //sayilar[4] = 45;
            //sayilar[5] = 23;

            //double[] rakamlar = { 12, 12.5, 23.4f }; 

            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

            //Console.WriteLine(isimler[2]);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            #region 1.Örnek

            // 5 elemanlı bir diziye isim atayıp kullanıcıya gösteriniz

            //string[] isimler = new string[5];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("isim girin:");
            //    isimler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Dizideki isimler:");
            //for (int j = 0; j < isimler.Length; j++)
            //{
            //    Console.WriteLine(isimler[j]);
            //}

            #endregion

            #region 2.Örnek

            // Aşağıdaki dizide tanımlı sayılardan çiftleri ayrı tekleri ayrı toplayarak sonucunu ekrana yazdırınız.
            
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 };

            int cifttoplam = 0;
            int tektoplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cifttoplam += sayilar[i];
                }
                else 
                {
                    tektoplam += sayilar[i];
                }
            }
            Console.WriteLine("TekToplam:"+tektoplam);
            Console.WriteLine("ÇiftToplam:"+cifttoplam);


            #endregion

            Console.ReadLine();


        }
    }
}
