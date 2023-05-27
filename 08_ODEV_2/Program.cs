using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_ODEV_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bankamatik
            /*   
             *   250 tl parası olacak 
            Bir bankamatik düşünülerek tasarlanacak bir program  için 
            Kartlı işlem    1
            Kartsız işlem   2
            //********Kartlı işlem bölümü
            Şifre istenecek=> Şifre:ab18
            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //*******************Ana Menü 
            Para Çekmek için    1
            Para yatırmak için  2
            Para Transferleri   3
            Eğitim Ödemeleri    4
            Ödemeler            5
            Bilgi Güncelleme    6
            //*********************Seçim 1************
            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            Ana meüye dönmek için   9
            Çıkmak için             0
            //******************Seçim 2***********************
            Kredi Kartına   1
            Kendi Hesabınıza yatırmak için  2
            Ana Menü        9
            Çıkmak için     0
            //------------------------------------
            //----1
            Kredi kardı için en az 12 haneli kart numarasını girsin
            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            Ana Menü        9
            Çıkmak için     0
            //--------------------------
            //---2
            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0
            //*****************************Seçim 3
            Başka Hesaba EFT    1
            Başka Hesaba Havale 2
            //---------------------------------
            //--1
            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------
            //---2
            hesap için 11 haneli hesap numarası işlemler doğru ise
            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            Ana Menü        9
            Çıkmak için     0
            //****************Seçim 4
            Eğitim Ödemeleri sayfası arızalı
            Ana Menü        9
            Çıkmak için     0
            //****************************Seçim 5
            Elektrik Faturası       1
            Telefon Faturası        2
            İnternet faturası       3
            Su Faturası             4
            OGS Ödemeleri           5
            //-----------------------------------------
            //---1 => bütün faturala için aşağıdaki şart yeterli
            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------------
            //***************Seçim 6
            Şifre değiştirmek için 1
            Şifre değiştirme işlemi gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0

             */
            #endregion

            double bakiye = 2500;
            string sifre = "ab18";
            while (true)
            {
                Console.WriteLine("Kartlı İşlem 1\nKartsız İşlem 2\nÇıkış 3\nSeçiminiz:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                  
                    bool giris = false;
                    int hak = 3;
                    while (hak>0)
                    {
                        Console.WriteLine("Şifreniz:");
                        string sfr = Console.ReadLine();
                        if (sfr == sifre)
                        {
                            giris = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Şifre hatalı!!");
                        }
                        hak--;
                    }
                    if (giris == true)
                    {
                        while (true)
                        {
                            Console.WriteLine("************ ANA MENÜ ****************");
                            Console.WriteLine("Para Çekme 1\nPara Yatırma 2\nPara Transferi 3\nEğitim Ödemeleri 4 \nÖdemeler 5\nBilgi Güncelleme 6\nÇıkış Q\nSeçiminiz:");
                            string secimMenu = Console.ReadLine().ToUpper();
                            if (secimMenu == "1")
                            {      
                                paracek:
                                Console.WriteLine("Çekmek istediğiniz miktar:");
                                double miktar = Convert.ToDouble(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Çekilen Miktar:{0} Yeni Bakiye:{1}",miktar,bakiye);
                                    //Console.WriteLine($"Çekilen Miktar:{miktar} Yeni Bakiye:{bakiye}");
                                    //Console.WriteLine("Çekilen Miktar:"+miktar+" Yeni Bakiye:"+bakiye);
                                    Thread.Sleep(3000);
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye");     
                                }

                                Console.WriteLine("Anamenü 9\nÇıkış 0\nŞeçiminiz:");
                                int cevap = Convert.ToInt32(Console.ReadLine());
                                if (cevap != 9)
                                {
                                    Environment.Exit(0);
                                }                              


                            }
                            else if (secimMenu == "2") 
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                double miktar = Convert.ToDouble(Console.ReadLine());

                                bakiye += miktar;
                                Console.WriteLine("Yeni Bakiye:"+bakiye);
                            }
                            else if (secimMenu == "3") 
                            {
                                Console.WriteLine("EFT 1\nHavale 2\nSeiçimiz:");
                                string secimtrans = Console.ReadLine();

                                if (secimtrans == "1")
                                {
                                    Console.WriteLine("Başında tr olacak şekilde IBAN giriniz:");
                                    string IBAN = Console.ReadLine().ToUpper();

                                    if(IBAN.StartsWith("TR") && IBAN.Length == 14)
                                    {
                                        Console.WriteLine("Transfer edilecek miktar:");
                                        double miktar = Convert.ToDouble(Console.ReadLine());

                                        if (bakiye >= miktar)
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine("Yeni Bakiye:"+bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("IBAN hatalı!!");
                                    }
                                }
                                else if (secimtrans == "2")
                                {
                                    Console.WriteLine("11 haneli hesap numarası giriniz:");
                                    string hesapNo = Console.ReadLine();

                                    if (hesapNo.Length == 11)
                                    {
                                        Console.WriteLine("Transfer edilecek miktar:");
                                        double miktar = Convert.ToDouble(Console.ReadLine());

                                        if (bakiye >= miktar)
                                        {
                                            bakiye -= miktar;
                                            Console.WriteLine("Yeni Bakiye:" + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("hatalı hesap numarası");
                                    }
                                }

                            }
                            else if (secimMenu == "4") { Console.WriteLine("Eğitim Ödemeleri Arızalı"); }
                            else if (secimMenu == "5") { }
                            else if (secimMenu == "6") 
                            {
                                Console.WriteLine("Eski Şifre:");
                                string oldpass = Console.ReadLine();
                                
                                if (oldpass == sifre)
                                {
                                    Console.WriteLine("Yeni Şifreniz:");
                                    string newpass = Console.ReadLine();
                                    Console.WriteLine("Tekrar Yeni Şifreniz:");
                                    string renewpass = Console.ReadLine();

                                    if (newpass == renewpass)
                                    {
                                        sifre = newpass;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yeni şifreler uyuşmuyor");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Şifre hatası!");
                                }


                            }
                            else if (secimMenu == "Q") { break; }
                            else { Console.WriteLine("Hatalı Menü Seçimi!!"); }

                        }




                    }
                    else
                    {
                        Console.WriteLine("Hakkınız Bitti");
                    }
                   

            









                }
                else if (secim == "2")
                {
                    Console.WriteLine("Kartsız Menüsü ARIZALI!!!");
                }
                else if (secim == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

            }
            
        }
    }
}
