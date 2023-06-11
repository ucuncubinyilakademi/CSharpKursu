using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Arrays_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************************** ÖDEV **********************//
            // Giriş alanında admin girişi yapılırsa ürün ve fiyat bilgileri girilsin
            // Giriş alanında member girişi yapılırsa 
            // dizi ürünler[Kola,bisküvi,çikolata]
            // dizi fiyat[7,3,2]
            // Ürünler ekrana yazdırın. Müşteri ürün adını girerek ürün almak istesin. İstenilen ürün fiyatını ekrana yazdırarak kullanıcıdan para alın ve para üstünü verin
            //  
            string[] urunler = new string[10];
            urunler[0] = "Bisküvi";
            urunler[1] = "Kola";
            urunler[2] = "Çikolata";
            urunler[3] = "Gofret";
            urunler[4] = "Kek";

            double[] fiyat = new double[10];
            fiyat[0] = 5;
            fiyat[1] = 5.75;
            fiyat[2] = 2.35;
            fiyat[3] = 4.25;
            fiyat[4] = 1.15;

            string admin = "altan";
            string pass = "123";

            Console.WriteLine("OTOMATA HOŞGELDİNİZ...");
            Console.WriteLine("Ürün almak için 1\nTeknik giriş için 2");
            string giris = Console.ReadLine();
            switch (giris)
            {
                case "1":
                    break;
                case "2":
                    int hak = 3;
                    while (hak > 0)
                    {
                        hak--;
                        Console.WriteLine("Kullanıcı adı:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Şifre:");
                        string sfr = Console.ReadLine();
                        if (user == admin && sfr == pass)
                        {
                            Console.WriteLine("Giriş başarılı\n");
                            Console.WriteLine("Ürün Ekleme için 1\nÜrün Çıkarma için 2\nÜrün Güncellemek için 3");
                            string cvp = Console.ReadLine();
                            if (cvp == "1")
                            {
                                while (true)
                                {
                                    int j = 0;
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        if (!string.IsNullOrEmpty(urunler[i]))
                                        {
                                            Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                            j++;
                                        }
                                    }
                                    Console.WriteLine("\nYeni Ürün Adı:");
                                    urunler[j] = Console.ReadLine();
                                    Console.WriteLine("Yeni Ürün Fiyatı:");
                                    fiyat[j] = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Yeni ürün eklemeye devam edecek misiniz?(E/H)");
                                    string cevap = Console.ReadLine().ToUpper();
                                    if (cevap == "H")
                                    {
                                        Console.WriteLine("Ürün eklemeden çıkılıyor.");
                                        Thread.Sleep(3000);
                                        break;
                                    }
                                }
                            }
                            else if (cvp == "2")
                            {
                                int j = 0;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                        j++;
                                    }
                                }
                                Console.WriteLine("Silinecek ürün adını giriniz:");
                                string urunadi = Console.ReadLine();
                                if (urunler.Contains(urunadi))
                                {
                                    int indx = Array.IndexOf(urunler, urunadi);
                                    Array.Clear(urunler, indx, 1); //RemoveAt metodu da kullanılabilir.
                                    Array.Clear(fiyat, indx, 1);
                                    for (int i = 0; i < urunler.Length; i++)
                                    {
                                        if (!string.IsNullOrEmpty(urunler[i]))
                                        {
                                            Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                        }
                                    }
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Ürün Adı Hatalı!!!");
                                }

                            }
                            else if (cvp == "3")
                            {
                                int j = 0;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(j + "-" + urunler[i] + ": " + fiyat[i]);
                                        j++;
                                    }
                                }
                                Console.WriteLine("Güncellenecek ürün numarasını giriniz");
                                int no = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ürün adını giriniz");
                                string urunadi = Console.ReadLine();
                                Console.WriteLine("ürün fiyatını giriniz");
                                double fyt = Convert.ToDouble(Console.ReadLine());
                                urunler[no] = urunadi;
                                fiyat[no] = fyt;
                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    if (!string.IsNullOrEmpty(urunler[i]))
                                    {
                                        Console.WriteLine(urunler[i] + ": " + fiyat[i]);
                                    }
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                                break;
                            }


                            break;


                        }
                        else
                        {
                            Console.WriteLine("HATALI GİRİŞ");
                        }
                    }

                    Console.WriteLine("Hakkınız bitti");
                    break;

            }
        }
    }
}
