using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_5
{
     internal class DORTISLEM
    {
        public static int Topla(int sonuc)
        {
            //Console.WriteLine("Sayı1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());          

            return sonuc + sayi1;
        }
        public static int Cikar(int sonuc)
        {
            //Console.WriteLine("Sayı1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            return sonuc - sayi1;
        }
        public static int Carp(int sonuc)
        {
            //Console.WriteLine("Sayı1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            return sonuc * sayi1;
        }
        public static int Bolme(int sonuc)
        {
            //Console.WriteLine("Sayı1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            return sonuc / sayi1;
        }
    }
}
