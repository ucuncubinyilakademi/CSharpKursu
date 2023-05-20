using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IF_ELSEIF_ELSE_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 250 tl geçerse ucuz ürüne  %25 indirim uygulayınız

            //Console.WriteLine("1.Ürün Fiyatı:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.Ürün Fiyatı:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = fiyat1 + fiyat2;

            //if (toplam > 250)
            //{
            //    if (fiyat1 > fiyat2)                
            //        fiyat2 = fiyat2 * 0.75;

            //    else                
            //        fiyat1 *= 0.75;                

            //    Console.WriteLine("Ödeme:"+(fiyat1+fiyat2));
            //}
            //else
            //{
            //    Console.WriteLine("Ödeme:"+toplam);
            //}

            #region 2.Yol
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
                    
            if ((fiyat1+fiyat2) > 250 )
            {
                if (fiyat1 > fiyat2)
                    fiyat2 = fiyat2 * 0.75;

                else
                    fiyat1 *= 0.75;               
            }

            Console.WriteLine("Ödeme:"+(fiyat1+fiyat2));

            #endregion

            Console.ReadLine();

        }
    }
}
