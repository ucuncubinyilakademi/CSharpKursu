using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ODEV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * ÖDEV:
             kullanıcıdan alınan cinsiyet bilgisine göre
             ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> KADIN ise
                yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 4500 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 4500 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */

            Console.WriteLine("Cinsiyet(E/K):");
            string cinsiyet = Console.ReadLine().ToUpper();

            switch (cinsiyet)
            {
                case "E":
                    Console.WriteLine("Yaşınız:");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaşınız:");
                        double maas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("İKRAMİYE:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:?");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaşınız:");
                            double maas = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("İKRAMİYE:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal!!");
                        }
                    }
                    break;
                case "K":
                    Console.WriteLine("Yaşınız:");
                    int yas2 = Convert.ToInt32(Console.ReadLine());
                    if (yas2 >= 58)
                    {
                        Console.WriteLine("Maaşınız:");
                        double maas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("İKRAMİYE:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Günü:?");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 4500)
                        {
                            Console.WriteLine("Maaşınız:");
                            double maas = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("İKRAMİYE:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal!!");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı Cinsiyet Bilgisi!!!.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
