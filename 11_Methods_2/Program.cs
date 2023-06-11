using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //kullanıcıdan alınacak bir ürün fiyatın KDV uygulayarak yeni fiyatı kullanıcıya gösteriniz
            //KDVUygula=>%18

            //Console.WriteLine("Fiyat:");
            //double f = Convert.ToDouble(Console.ReadLine());

            //KDVUYGULA(f);
            #endregion

            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız
            Console.WriteLine("1.Ürün fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Ürün fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
            Indirim2(fiyat1, fiyat2);

            Console.ReadLine();
        }

        static void KDVUYGULA(double fiyat)
        {
            Console.WriteLine(fiyat*1.18);
        }

        static void Indirim2(double f1, double f2)
        {
            if (f1 > f2)
                f1 = f1 * 0.7;
            else
                f2 = f2 * 0.7;

            Console.WriteLine("3.Ürün ister misiniz?");
            string cevap = Console.ReadLine().ToUpper();

            if(cevap=="E")
            {
                Indirim3(f1, f2);
            }
            else
            {
                Console.WriteLine("Ödeme:" + (f1 + f2));
            }

        }

        static void Indirim3(double f1, double f2)
        {
            Console.WriteLine("3.Ürün fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            f3 = f3 / 2;
            Console.WriteLine("Ödeme:" + (f1 + f2 + f3));
        }
    }
}
