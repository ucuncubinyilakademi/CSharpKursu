using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *********** METOTLAR *************
             
            * Metot: Belirli işlemi isim vererek tanımlamımızı ve ihtiyaç duyduğumuz zamanlarda verilen isim ile ulaşarak kullanmamızı sağlar.
            * Metotlar iç içe tanımlanmazlar. 
            * Metotlar () işareti ile tanımlanırlar.
            
            Metotlar 2 ye ayrılır. 
            * Değer Döndürmeyen Metotlar
            * Değer Döndüren Metotlar
                

            ***** DEĞER DÖNDÜRMEYEN METOTLAR (void) *****
            Metodun yapmış olduğu işlemin sonucunu çağrıldığı yere geri getirmemesi anlamına gelir.


            ** Metot Tanımlama **
            
            erişimbelirteci: public: Bütün solution tarafında erişibilir.,
                             private,protected,internal
            void : metotun değer döndürmeyeceğini belirtir.
            static: Bir yapının direk erişilebilir(kullanılabilir) olduğunu belirtir. static bir tanımın içinde yine static yapı kullanılması zorunludur.

            public void Toplama()
            {
                //Metot İşlem komutları
            }             

            ** Metot Çağırma **
            metotName();
             */

            Toplama();

            Console.ReadKey();
        }

        public static void Toplama()
        {
            Console.WriteLine("Sayı1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam:" + toplam);
        }
       
    }
}
