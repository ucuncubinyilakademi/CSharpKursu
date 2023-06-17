using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya 4 işlem yaptıran ve her seferinde 2 sayı alıp sonucu ekrana yazdıran method. Kullanıcı çıkmak isteyene kadar her seferin hangi işlemi yapmak istersiniz diye sorsun.
            int sonuc = 0;
            Console.WriteLine("İşlem Seçiniz(+,-,*,/):");
            string islem = Console.ReadLine();
            while (true)
            {               

                if (islem == "+")
                {
                    sonuc=DORTISLEM.Topla(sonuc);
                }
                else if (islem == "-")
                {
                    sonuc = DORTISLEM.Cikar(sonuc);
                }
                else if (islem == "*")
                {
                    sonuc = DORTISLEM.Carp(sonuc);
                }
                else if (islem == "/")
                {
                    sonuc = DORTISLEM.Bolme(sonuc);
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem!!");
                }
                Console.WriteLine("Sonuç:"+sonuc);
                Console.WriteLine("Devam etmek ister misiniz?(E/H)");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap != "E")
                    break;
                else
                {
                    Console.WriteLine("İşlem Seçiniz(+,-,*,/):");
                    islem = Console.ReadLine();
                }
            }

            Console.ReadLine();
        }

        
    }
}
