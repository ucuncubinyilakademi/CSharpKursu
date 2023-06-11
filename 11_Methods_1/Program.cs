using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_1
{
    internal class Program //202
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan iki sayı ve işlem alan bir method yazınız. Verilen sayılara belirtilen işlemi yapıp sonucunu ekrana yazdıran method.
            //DortIslem();


            //Console.WriteLine("İşlem seçiniz(+,-,*,/):");
            //char islem = Convert.ToChar(Console.ReadLine());

            //if (islem == '+')            
            //    DORTISLEM.Toplama();                      
            //else if (islem == '-')
            //    DORTISLEM.Cikarma();
            //else if (islem == '*')
            //    DORTISLEM.Carpma();
            //else if (islem == '/')
            //    MATEMETİK.Bolme();



            //MATEMEATİK class METHOD KULLANIMI


            //MATEMETİK.Toplama(11, 33);


            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            MATEMETİK.Cikarma(sayi1, sayi2);

            Console.ReadLine();
        }

        static void DortIslem()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem(+,-,*,/) seçiniz:");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine(s1 + s2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(s1 - s2);
            }
            else if (islem == "*")
            {
                Console.WriteLine(s1 * s2);
            }
            else if (islem == "/")
            {
                Console.WriteLine(s1 / s2);
            }
            else { Console.WriteLine("Hatalı işlem seçimi!!!"); }
        }

    }

    class DORTISLEM //201
    {
        public static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 + s2);
        }
        public static void Cikarma()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

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
