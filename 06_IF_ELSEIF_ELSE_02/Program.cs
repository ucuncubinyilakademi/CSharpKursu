using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IF_ELSEIF_ELSE_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan aylık gelirini isteyin. 
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            #region 1.Yol
            //Console.WriteLine("Gelirinizi Giriniz:");
            //int gelir = Convert.ToInt32(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    double netGelir = gelir * 0.88;//(gelir-(gelir*12)/100);
            //    Console.WriteLine("Net Gelir:" + netGelir);
            //    //-----------
            //    Console.WriteLine("Net Gelir:" + (gelir * 0.88));
            //}
            //else
            //{
            //    double netGelir = gelir * 0.91;
            //    Console.WriteLine("Net Gelir:" + netGelir);
            //    //-----------
            //    Console.WriteLine("Net Gelir:" + (gelir * 0.91));
            //}
            #endregion



            #region 2.Yol
            //Console.WriteLine("Gelirinizi Giriniz:");
            //int gelir = Convert.ToInt32(Console.ReadLine());

            //double netGelir=0;

            //if (gelir > 40000)
            //{
            //    netGelir = gelir * 0.88;
            //}
            //else
            //{
            //    netGelir = gelir * 0.91;
            //}

            //Console.WriteLine("Net Gelir:" + netGelir);
            #endregion


            Console.WriteLine("Gelirinizi Giriniz:");
            int gelir = Convert.ToInt32(Console.ReadLine());

            double netGelir = gelir > 40000 ? gelir * 0.88 : gelir * 0.91;

            Console.WriteLine("Net Gelir:" + netGelir);

            Console.ReadLine();

        }
    }
}
