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

            Altan.Topla(1,2);
            Altan.Topla(1,2.5);
            Altan.Topla(1,2,3);

            Console.ReadLine();

            Console.WriteLine("dsfdsadsd");
            Console.WriteLine(12);
            Console.WriteLine(12.5);
        }
    }
}
