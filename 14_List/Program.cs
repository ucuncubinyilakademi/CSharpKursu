using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10]; //Array: Boyut ve veritipi zorunlu
            //ArrayList arraylist = new ArrayList(); //ArrayList: Boyut ve veritipi zorunlu değil.

            //List<int> ints = new List<int>(); //List:Veri tipi zorunlu.

            //ints.Add(12);
            //ints.Add(13);

            //List<int> _ints = new List<int>() { 12, 13 };



            //string ad = "Altan";
            //string soyad = "Demirci";
            //string ad2 = "Emre";
            //string soyad2 = "Yılmaz";
            //string ad3 = "Mevlüt";
            //string soyad3 = "Akmaz";

            //List<string> ogrenciler = new List<string>();
            //ogrenciler.Add(ad);
            //ogrenciler.Add(soyad);
            //ogrenciler.Add(ad2);
            //ogrenciler.Add(soyad2);
            //ogrenciler.Add(ad3);
            //ogrenciler.Add(soyad3);


            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            // INSTANCE => Örneklem
            Ogrenci o = new Ogrenci();
            o.ad = "Altan";
            o.soyad = "Demirci";
            o.yas = 33;

            ogrenciler.Add(o);

            Ogrenci o2 = new Ogrenci();
            o2.ad = "Emre";
            o2.soyad = "Yılmaz";
            o2.yas = 24;
            ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.ad = "Uras";
            o3.soyad = "Demirci";
            o3.yas = 24;
            ogrenciler.Add(o3);

            foreach (Ogrenci item in ogrenciler)
            {
                if (item.ad == "Emre")
                {
                    Console.WriteLine(item.ad);
                    Console.WriteLine(item.soyad);
                    Console.WriteLine(item.yas);
                }
              
            }





            //while (true)
            //{
            //    Ogrenci ogr = new Ogrenci();
            //    Console.WriteLine("ad:");
            //    ogr.ad = Console.ReadLine();
            //    Console.WriteLine("soyad:");
            //    ogr.soyad = Console.ReadLine();
            //    Console.WriteLine("Yaş:");
            //    ogr.yas = Convert.ToInt32(Console.ReadLine());

            //    ogrenciler.Add(ogr);
            //} 


            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        //Prop default olarak PRIVATE tanımlıdır.
        public string ad; //property
        public string soyad;
        public int yas;

        void yaz()
        {
            Console.WriteLine(ad);
        }
    }
}
