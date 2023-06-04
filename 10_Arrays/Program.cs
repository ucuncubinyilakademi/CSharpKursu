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

            //Random r = new Random();
            //int[] sayilar = new int[r.Next(10, 20)]; // 13

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = r.Next(0, 1000);
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}








            #endregion

            #region 4.Örnek
            //100 elemanlı bir dizi için 0-1000 arasında rastgele sayılar atayın. Bu dizinin elemanlarının sayı ortalamasını, en küçük değerini ve en büyük değerini gösteriniz

            //int[] sayilar = new int[100];

            //Random r = new Random();

            ////Dizi elemanlarını ekleme
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = r.Next(0, 1000);
            //}

            //Array.Sort(sayilar); // 0=>9

            ////En küçük
            //Console.WriteLine("EnKüçük:"+sayilar[0]);

            ////En büyük
            //Console.WriteLine("EnBüyük:"+sayilar[sayilar.Length-1]);


            //double toplam = 0;           

            //foreach (int item in sayilar)
            //{
            //    toplam += item;
            //}

            //double ortalama = toplam / sayilar.Length;
            //Console.WriteLine("Ortalama:"+ortalama);


            #endregion

            #region İKİ VE ÇOK BOYUTLU DİZİLER

            /*İKİ BOYUTLU DİZİLER*/
            //Tek boyutlu dizileri, tek satırlı; ancak çok sayıda sütuna sahip olabilecek bir tablo gibi düşünmüştük.
            //Çok boyutlu dizilerde ise satır sayısıda tıpkı sütun sayısı gibi değişiklik gösterir. 
            //Standart boyutlu dizilerden farklı olarak Yatay x koordinatının yanına bir de dikey y koordinatı gelir.
            //Çok boyutlu dizi düzenli ve düzensiz olarak ikiye ayrılabilir.

            #region DÜZENLİ DİZİLER
            //    MATRİS DİZİLER
            //    Dikey ve yataydaalacağı değerlerin sabit olduğu dizi şeklidir.

            //    Tanımlama şekli: 
            //int[,] sayilar = new int[3, 2]; // 3 satır 2 sütun 

            //    Dizi[0][0]    Dizi[0][1]
            //    Dizi[1][0]    Dizi[1][1]
            //    Dizi[2][0]    Dizi[2][1]

            //double[,] boyKilo = new double[2, 2];

            //Diziye Eleman Ekleme
            //boyKilo[0, 1] = 98;
            //boyKilo[0, 0] = 2.00;
            //boyKilo[1, 0] = 1.94;
            //boyKilo[1, 1] = 86;

            //Dizi Yazdırma
            //foreach (double item in boyKilo)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            //Console.WriteLine("Satır Sayısı:");
            //int satir = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sütun Sayısı:");
            //int sutun = Convert.ToInt32(Console.ReadLine());

            //int[,] sayilar = new int[satir,sutun];

            ////Diziye Eleman Ekleme
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.WriteLine("Sayı Gir:");
            //        sayilar[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write($"{i} : {sayilar[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}



            //# Örnek: 4x4'lük 0'lardan oluşan bir matris oluşturun(liste)
            //# 1. satırı 1-100 arası rastgele sayılardan oluşturunuz.
            //# 2. satırı Kullanıcıdan sayıları alınız.
            //# 3. satırda 1. satırın karelerini saklayınız.
            //# 4. satırda 2. satırdaki verilerin 5'er fazlasını saklayınız.

            int[,] matris = new int[4, 4];
            Random r = new Random();
            for (int i = 0; i < 4; i++) //satır
            {
                if (i == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matris[i, j] = r.Next(1, 100);
                    }
                }
                else if (i == 1)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("Sayı Giriniz:");
                        matris[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (i == 2)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matris[i, j] = matris[0, j] * matris[0, j];
                    }
                }
                else if (i == 3)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matris[i, j] = matris[1, j] + 5;
                    }
                }
            }


            //foreach (int item in matris)
            //{
            //    Console.WriteLine(item);
            //}


            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(matris[x,y] +" ");
                }
                Console.WriteLine();
            }


            #endregion


            Console.ReadLine();


        }
    }
}
