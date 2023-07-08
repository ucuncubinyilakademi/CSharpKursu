using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Manav_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MANAV
            /*
          ******** MANAV OTOMASYONU *********
1.Toptancı,Manav ve Müşteri alanlarımız olacak
2.Manav toptancıdan isteğine göre meyve,sebze alacak ve müşteri de manavın toptancıdan aldığı ürünleri alabilecek.
3.Toptancı için meyve ve sebze programın başında tanımlanacak.(Dolu liste yapılacak)
4.Manav için meyve sebze listeleri boş olarak tanımlanacak
5.Müşteri için tek liste yeterli boş olarak
6.Program başladığında HALE HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
7.M tuşuna basıldıysa Toptancının meyve listesi S tuşuna basıldıysa Toptancının sebze listesi ekrana yazdırıp manavın bir ürün alması istenecek
8.Mesela Elma istediyse manavın meyveler listesine elma değeri eklenecek ve kaç kilo diye sorularak kilo alınacak
9.Başka bir arzunu var mı? Evet E veya Hayır H
10.Evet dendiyse Tekrar 6. adıma gidilecek ve işlemler tekrar edilecek
11.Hayır dendiyse MANAVA HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
12.Manav Bölümünde müşteri M bastı diyelim 
13.Manavın toptancıdan aldığı meyveler listelenecek ve müşterinin bir meyve girmesi beklenecek
14.Mesela Elma istediyse kaç kilo diye sorularak kilo alınacak
15.Müşterinin istediği kilo ile manavın toptancıdan aldığı elmanın kilosu karşılaştırılacak 
16.Eğer manavın elinde yeterli miktarda elma varsa müşterinin listesine elma değeri eklenecek
17.Başka bir arzunu var mı? Evet E veya Hayır H
18.Evet dendiyse Tekrar 11. adıma gidilecek ve işlemler tekrar edilecek
19.Hayır dendiyse Müşteri listesi ekrana yazdırılsın.

          */
            #endregion

            ArrayList manavmeyve = new ArrayList();
            ArrayList manavsebze = new ArrayList();
            ArrayList musteri = new ArrayList();
            int ELMA = 0, ARMUT = 0, MUZ = 0;

            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M - Sebze S - Çıkış için Q\n Seçiminiz:");
                string sec = Console.ReadLine().ToLower();

                if (sec == "m")
                {
                    while (true)
                    {
                        Console.WriteLine("1-ELMA\n2-ARMUT\n3-MUZ\n4-Çıkış\nSeçiminiz:");
                        int meyve = Convert.ToInt32(Console.ReadLine());

                        if (meyve == 1)
                        {
                            manavmeyve.Add("ELMA");
                            Console.WriteLine("Kaç kilo?");
                            ELMA += Convert.ToInt32(Console.ReadLine());
                          
                        }
                        else if (meyve == 2)
                        {
                            manavmeyve.Add("ARMUT");
                            Console.WriteLine("Kaç kilo?");
                            ARMUT += Convert.ToInt32(Console.ReadLine());
                         
                        }
                        else if (meyve == 3)
                        {
                            manavmeyve.Add("MUZ");
                            Console.WriteLine("Kaç kilo?");
                            MUZ += Convert.ToInt32(Console.ReadLine());
                          
                        }
                        else if (meyve == 4)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim!..");
                        }

                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap != "E")
                        {
                            break;
                        }
                    }
                    
                }
                else if (sec == "s")
                {

                }
                else if (sec == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }

            while (true)
            {
                Console.WriteLine("MANAVA HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M - Sebze S - Çıkış için Q\n Seçiminiz:");
                string sec = Console.ReadLine().ToLower();

                if (sec == "m") 
                {
                    if (manavmeyve.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir...");
                        continue;
                    }

                    foreach (string item in manavmeyve)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Seçiminiz:");
                    string meyve = Console.ReadLine().ToUpper();

                    if (!manavmeyve.Contains(meyve))
                    {
                        Console.WriteLine("Mevcut olmayan meyve girildi.");
                        continue;
                    }

                    if (meyve == "ELMA")
                    {
                        Console.WriteLine("Kaç kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (ELMA >= kilo)
                        {
                            ELMA -= kilo;
                            if (ELMA == 0)
                            {
                                manavmeyve.Remove(meyve);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kilo uygun değil");
                        }
                    }
                  

                }
                else if (sec == "s") { }
                else if (sec == "q") { break; }
                else { Console.WriteLine("Hatalı Seçim!!"); }
            }
           


        }
    }
}
