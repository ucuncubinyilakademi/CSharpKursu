using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ************* OPERATÖRLER **************   */

            //**** Aritmatik Operatörler(+ - * / %) ****
            /*
            int sayi = 5;
            int sayi2 = 7;
            int sonuc1 = sayi + sayi2;
            int sonuc2 = sayi - sayi2;
            int sonuc3 = sayi * sayi2;
            int sonuc4 = sayi / sayi2;

            Console.WriteLine("Sonuç:"+sonuc1);
            Console.WriteLine("Sonuç:"+sonuc2);
            Console.WriteLine("Sonuç:"+sonuc3);
            Console.WriteLine("Sonuç:"+sonuc4);
         
           
            int sayi = 12;
            double sayi2 = 3.5;
            double sonuc = sayi / sayi2;
            Console.WriteLine(sayi/sayi2);

            /*
            Mod Alma (%):
            Herhangi bir değeri bir değere % mod alırsanız kalanı verir.
            
            int sayi = 10;
            int bolen = 3;

            Console.WriteLine(sayi%bolen);
             */


            //**** Bir Arttırma ve Bir Eksiltme Operatörleri(++, --) ****
            //int sayi = 5;
            //sayi++; //sayi = sayi + 1;
            //sayi--;

            //int a = 5;
            //int i = ++a;


            //int a = 5;
            //int i = a++;

            //**** MANTIKSAL OPERATORLER ****

            // Trendyol Giriş Kayıtları
            //string username = "altanemre";
            //string password = "1";


            //bool sonuc = username == "altanemre";
            //bool sonuc2 = password == "12";
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc==sonuc2);

            //bool girisDurumu = username == "altanemre" && password == "1";

            //Console.WriteLine("Giriş:"+girisDurumu);
            // AND(VE) MANTIKSAL OPERATÖRÜ
            //Birden fazla karşılaştırma durumu olduğunda ve her durumun doğru olması isteniliyor ise AND && operatörü kullanılır.

            /*
             
             Username      Şİfre        Sonuç
               F           F             F
               F           T             F
               T           F             F
               T           T             T
             
             */


            //bool girisDurumu = username == "altanemre34" && password == "1";
            //Console.WriteLine(girisDurumu);

            // OR(VEYA) MANTIKSAL OPERATÖRÜ
            //Birden fazla karşılaştırma durumu olduğunda ve durumlardan herhangi birinin doğru olması isteniliyor ise OR || operatörü kullanılır.

            // INSTAGRAM 
            /*
             
             
           (  email      Phone        Username  )   Sonuc
               F           F             F            F
               F           T             F            T
               T           F             F            T
               F           F             T            T
             */
             
            string username = "altanemre";
            string email = "sexi_velet_17@hotmail.com";
            string phone = "5366295131";
            string password = "1";


            Console.WriteLine("Email/Phone/Username:");
            string kullanici = Console.ReadLine();          

            Console.WriteLine("Password:");
            string sifre = Console.ReadLine();


            bool sonuc = (username == kullanici || phone == kullanici || email == kullanici) && password == sifre;

            Console.WriteLine("Giriş:"+sonuc);
            


            // NOT(Değil) Operatörü
            // Bool değeri terslemeyi sağlar.

            //bool sonuc = true;

            //Console.WriteLine(!sonuc);

            // **** ATAMA OPERATÖRÜ(=) **** 
            int sayi = 6;

            sayi += 2; //sayi = sayi + 2;
            sayi -= 2; //sayi = sayi - 2;
            sayi *= 2; //sayi = sayi * 2;
            sayi /= 2; //sayi = sayi / 2;


            // **** KIYAS OPERATORLER( ?-true :-false) ****
            /*
            int sayi = 12;
            int sayi2 = 6;

            //Console.WriteLine(sayi==sayi2 ? "EŞİTTİR" : "YANLIŞ");
            //Console.WriteLine(sayi>sayi2 ? sayi : sayi2);
            Console.WriteLine(sayi>sayi2 ? sayi-2 : sayi2+2);
             */


            // **** KARŞILAŞTIRMA OPERTÖRLERİ (>,<,>=,<=,==,!=)****
            /*
            int sayi = 5;
            int sayi2 = 6;

            bool sonuc  = sayi > sayi2;
            bool sonuc2 = sayi < sayi2;
            bool sonuc3 = sayi >= sayi2;
            bool sonuc4 = sayi <= sayi2;
            bool sonuc5 = sayi == sayi2;
            bool sonuc6 = sayi != sayi2;
            */



            Console.ReadKey();
        }
    }
}
