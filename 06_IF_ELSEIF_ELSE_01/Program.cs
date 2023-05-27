using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IF_ELSEIF_ELSE_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Örnek
            // Kullanıcıdan haftanın gün sayısını alıp ekrana gün adını yazdırınız.
            /*
            Console.WriteLine("Haftanın kaçıncı günü?");
            int gun = Convert.ToInt32(Console.ReadLine());

            if (gun > 7 || gun < 1)
            {
                Console.WriteLine("Hatalı Gün Bilgisi");
            }
            else if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else
            {
                Console.WriteLine("Pazar");
            }
            */
            #endregion

            //B Sınıfı ehliyet almak isteyen bir kişinin 18 ile 45 yaş aralığında olması ve sağlık raporunu onaylı olması gereklidir.

            #region 1.Yol

            Console.WriteLine("Yaşınız:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 17 && age < 46)
            {
                Console.WriteLine("Sağlık Rapor Sonucu(E/H):");
                //string sonuc = Console.ReadLine().ToLower();//Bütün okunan değeri küçük harfe çevirir.
                string sonuc = Console.ReadLine().ToUpper();//Bütün okunan değeri BÜYÜK harfe çevirir.
                if (sonuc == "E")
                {
                    Console.WriteLine("Ehliyet aldınız.");
                }
                else
                {
                    Console.WriteLine("Sağlık Sebebiyle Ehliyet alamazsınız");
                }
            }
            else
            {
                Console.WriteLine("Yaşınızdan dolayı ehliyet alamazsınız.");
            }


            #endregion

            #region 2.Yol
            //Console.WriteLine("Yaşınız:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age > 17 && age < 46)
            //{
            //    Console.WriteLine("Sağlık Raporu:(E/H)");
            //    string result = Console.ReadLine().ToUpper();
            //    if (result == "E")
            //        Console.WriteLine("Ehliyet Alabilir");

            //    else
            //        Console.WriteLine("Ehliyet ALAMAZ Sağlık Uygun Değil!!!");

            //}
            //else
            //{
            //    Console.WriteLine("Ehliyet ALAMAZ Yaş Uygun Değil!!!");
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
