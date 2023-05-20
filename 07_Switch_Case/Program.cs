using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Örnek
            // Kullanıcıdan 1 ile 3 arasında bir sayı alınız ve sayının harfli yazılışını ekrana yazdırınız
            /*
            Console.WriteLine("1 ile 3 arasında sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 1)
            {
                Console.WriteLine("Bir");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("İki");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Üç");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş");
            }
            */
            /* SWITCH CASE: if e benzer şekilde çalışan bir karşılaştırma işlemidir. */

            //Console.WriteLine("1 ile 3 arasında sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("Bir");
            //        break;
            //    case 2:
            //        Console.WriteLine("iki");
            //        break;
            //    case 3:
            //        Console.WriteLine("Üç");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;
            //}

            #endregion

            // Kullanıcıdan haftanın gün sayısını alıp ekrana gün adını yazdırınız.
            Console.WriteLine("Haftanın Kacıncı Günü Olduğunu Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2:
                    Console.WriteLine("Salı");
                    break;

                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Hatalı Gün Girişi");
                    break;

            }

            Console.ReadLine();
        }
    }
}
