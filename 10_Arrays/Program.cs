using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            #region ARRAY SINIFI ÖZELLİKLERİ VE METOTLARI

            #region Clear()

            // Verilen dizi içerisinde belirtilen index den başlayarak belirtilen uzunluk kadar data siler.
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //foreach(string aa in isimler)
            //{
            //    Console.WriteLine(aa);
            //}



            //Array.Clear(isimler,1,2);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}



            #endregion


            #region Copy()
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

            //string[] adlar = new string[10];
            ////Array.Copy(isimler, adlar, 2);
            //Array.Copy(isimler, 1, adlar, 4, 3);

            ////foreach (string item in isimler)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (string item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region IndexOf()

            //IndexOf:Verilen dizideki istenilen elemanın ilk görüldüğü indexi

            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Ceylan", "Kerem", "Ceylan" };

            ////Console.WriteLine(Array.IndexOf(isimler,"Ceylan"));

            ////int indx = Array.IndexOf(isimler, "Ceylan");
            ////Console.WriteLine(indx);

            //Console.WriteLine(Array.IndexOf(isimler, "Ceylan", 2));

            #endregion

            #region LastIndexOf()

            //LastIndexOf:Verilen dizideki istenilen elemanın son görüldüğü indexi

            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Ceylan", "Kerem","Ceylan" };

            //Console.WriteLine(Array.LastIndexOf(isimler, "Ceylan"));

            #endregion

            #region ReSize()

            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

            //Array.Resize(ref isimler, 10);

            //isimler[5] = "Duru";

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Sort() and Reverse()
            //Sort: A->Z 0->9 sıralama yapar.
            //Reverse: Tanımlı diziyi ters sıralar.(ters çevirir.)
            //string[] isimler = { "Ceylan", "Uras", "Altan", "Kıvanç", "Kerem", "Işık", "Çağatay" };

            //Array.Sort(isimler);
            //Array.Reverse(isimler);
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion

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

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 };

            //int cifttoplam = 0;
            //int tektoplam = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        cifttoplam += sayilar[i];
            //    }
            //    else 
            //    {
            //        tektoplam += sayilar[i];
            //    }
            //}
            //Console.WriteLine("TekToplam:"+tektoplam);
            //Console.WriteLine("ÇiftToplam:"+cifttoplam);


            #endregion

            #region 3.Örnek
            //bir dizinin eleman sayısı 10 ile 20 arsında olacak şekilde sistem tarafında otomatik atılmaktadır. Bu dizinin elemanlarını da sistem 0,1000 arasında otomatik atmaktadır.Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz

            Random r = new Random();
            int[] sayilar = new int[r.Next(10, 20)]; // 13

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(0, 1000);
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }


           
            




            #endregion

            Console.ReadLine();


        }
    }
}
