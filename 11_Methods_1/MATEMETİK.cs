using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_1
{
    internal class MATEMETİK
    {
        public static void Toplama(int s1,int s2) // 2 tane int tipinde parametre alacak
        {
            Console.WriteLine(s1 + s2);
        }
        public static void Cikarma(int s1, int s2)
        {          
            Console.WriteLine(s1 - s2);
        }
        public static void Carpma()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 * s2);
        }
        public static void Bolme()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 / s2);
        }
    }
}
