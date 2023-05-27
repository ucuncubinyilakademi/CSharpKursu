using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             **** KARAR YAPILARI(AKIŞ KONTROL) ****
             1-if else
             2-switch case
             3-try catch(hata ayıklama)
            
             IF - ELSEIF - ELSE
            * her durum kontrolü if deyimi ile başlar ve alternatif her durum için else if deyimi yazılır.if ve else if bloklarındaki durumlar(koşullar) sağlanmadığı diğer durumlar için else yazılır ve else diğer her durum için geçerli olduğunda KOŞUL YAZILMAZ.

             
             */
            //Bir kullanıcının yaşına göre bilgilendirme yapan if else kod bloğunu kodlayınız

            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            // bool durum = yas > 17;

            //Console.WriteLine(yas > 17 == true ? "Yetişkin" : "Çocuk");

            #region 1.Örnek

            //Bir kullanıcının yaşına göre bilgilendirme yapan if else kod bloğunu kodlayınız
            /*
             0-17 Çocuk
             18-33 Genç
             34-50 Orta Yaş
             51 Yaşlı
             */


            Console.WriteLine("Yaşınız:");
            int yas = Convert.ToInt32(Console.ReadLine());

            //if(yas>0 && yas < 18)
            //{
            //    Console.WriteLine("Çocuk");
            //}
            //else if(yas>17 && yas < 34)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if(yas>33 && yas < 51)
            //{
            //    Console.WriteLine("Orta Yaş");
            //}
            //else if(yas>50 && yas < 110)
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            //else
            //{
            //    Console.WriteLine("Yaş yanlış");
            //}

            //Console.ReadLine();

            //if (yas>=0 && yas < 18) //karşılaştırma true ise if e ait parantez içindeki kodlar çalışır.
            //{
            //    Console.WriteLine("Çocuk");
            //}
            //else if (yas>17 && yas < 34)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if(yas>33 && yas <= 50)
            //{
            //    Console.WriteLine("Orta Yaş");
            //}
            //else if(yas<150)
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            //else
            //{
            //    Console.WriteLine("Hata!!!");
            //}

            #region 2.Yöntem

            if(yas<0 || yas > 150)
            {
                Console.WriteLine("Hata!!!");
            }
            else if (yas < 18)
            {
                Console.WriteLine("Çocuk");
            }
            else if (yas < 34)
            {
                Console.WriteLine("Genç");
            }
            else if (yas <= 50)
            {
                Console.WriteLine("Orta Yaş");
            }
            else
            {
                Console.WriteLine("Yaşlı");
            }
           
            #endregion


            #endregion


            Console.ReadLine();
        }
    }
}
