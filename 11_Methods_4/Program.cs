
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // kendisine gönderilen int tipindeki dizinin içindeki tek sayıları toplayarak ekrana yazdıran method.
            Topla(sayilar);
            Console.ReadLine();
        }

        static void Topla(int[] list)
        {
            int toplam = 0;
            foreach (int item in list)
            {
                if (item % 2 != 0)
                {
                    toplam += item;
                }

            }
            Console.WriteLine("Toplam:"+toplam);
        }
    }
}
