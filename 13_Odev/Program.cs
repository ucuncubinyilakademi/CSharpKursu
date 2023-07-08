using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-10 arasında çarpım tablosunu yazdıran bir method tasarlayınız.

            //CarpimTablosunuYazdir();

            //Console.ReadLine();

            //klavyeden girilen değerler arasında rastgele sayı üreten ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı


            SayiUret();

            Console.ReadLine();


        }

        static void CarpimTablosunuYazdir()
        {
            // İki for döngüsü de rakam değişkenlerini 1 den 9 a kadar sayıyor. İçteki for, onu kapsayan forun her bir rakamı için 9 a kadar sayıp çarpıyor ve bunu yazdırıyor. Böylece çarpım tablomuzu elde ediyoruz.
            for (int ilkRakam = 1; ilkRakam < 10; ilkRakam++)
            {
                for (int ikinciRakam = 1; ikinciRakam < 10; ikinciRakam++)
                {
                    Console.Write(ikinciRakam + " x " + ilkRakam + " = " + (ilkRakam * ikinciRakam) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void SayiUret()
        {
            int[] sayilar = new int[10];

            Random r = new Random();

            Console.WriteLine("Başlangıç değeri:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değeri:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (basla > bitis)
            {
                for (int i = 0; i < 10; i++)
                {
                    sayilar[i] = r.Next(bitis, basla);
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    sayilar[i] = r.Next(basla, bitis);
                }
            }

            Console.WriteLine("Büyük Değer:"+ EnBuyukDeger(sayilar));
            Console.WriteLine("Küçük Değer:"+ EnKucukDeger(sayilar));

            DiziYazdir(sayilar);



        }

        static int EnBuyukDeger(int[] dizi)
        {
            int enbuyuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item > enbuyuk)
                    enbuyuk = item;
            }

            return enbuyuk;
        }

        static int EnKucukDeger(int[] dizi)
        {
            int enkucuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item < enkucuk)
                    enkucuk = item;
            }

            return enkucuk;
        }

        static void DiziYazdir(int[] dizi)
        {
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
