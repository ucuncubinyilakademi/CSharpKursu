using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD METOTLAR
            // Bir methodun aynı isimle birden fazla kez tanımlanmasına denir.
            //** Metot İmzası: Aynı isimle tanımlanan metotların mutlaka 
            //    *parametre sayısı veya parametre veri tipi farklı olmalıdır.

            //Altan.Topla(1,2);
            //Altan.Topla(1,2.5);
            //Altan.Topla(1,2,3);

            //Console.ReadLine();

            //Console.WriteLine("dsfdsadsd");
            //Console.WriteLine(12);
            //Console.WriteLine(12.5);



            //islem adında 3 metot yapınız
            //1. metot %18 kdv uygulaması yapsın
            //2.metot 3 sayının toplamını
            //3.metot aldığı değere 11 eklesin



        }

        static void Islem(double fiyat)
        {
            if (fiyat > 100)
                Console.WriteLine(fiyat * 1.18);
            else
                Console.WriteLine(fiyat);
        }

        static void Islem(int s1, int s2, int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }

        static void Islem(int sayi)
        {
            Console.WriteLine(sayi + 11);
        }
    }
}
