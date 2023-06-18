using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi : veritipi ve boyutu sabit olması gereklidir.

            //object[] sayilar = new object[3];

            //sayilar[0] = 12;
            //sayilar[1] = 11;
            //sayilar[2] = "3";


            //foreach (object item in sayilar)
            //{
            //    Console.WriteLine(5+(int)item);
            //}



            //ArrayList arrayList = new ArrayList(); //Veritipi kısıtı yok, boyut tanımıda yok.
            //arrayList.Add(1);
            //arrayList.Add("Ali");
            //arrayList.Add(12.5);
            //arrayList.Add(1.7f);
            //arrayList.Add(';');

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}


            //ArrayList arrayList = new ArrayList() { 11, 666,44, 23, 45, "Altan", "Zekiye", "Ceylan", "Merve", "Ece", "?", "!", ";" };

            //Console.WriteLine(arrayList.Capacity);
            //Console.WriteLine(arrayList.Count);


            //arrayList.Clear();
            //arrayList.Remove(11);
            //arrayList.RemoveAt(4);
            //arrayList.RemoveRange(4,3);
            //if (arrayList.Contains("Altann"))
            //{
            //    Console.WriteLine("Var");
            //}
            //arrayList.Insert(1, 666);

            //arrayList.Reverse();

            //arrayList.Sort();

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList arrayList = new ArrayList() {"Altan", "Zekiye", "Ceylan", "Merve", "Ece"};

            //ArrayList list = arrayList;

            //ArrayList list = (ArrayList)arrayList.Clone();


            //ArrayList list = new ArrayList(arrayList);
            //arrayList.Add("Furkan");
            //list.Add("Veli");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program

            ArrayList sayilar = new ArrayList();

            while (true)
            {
                Console.WriteLine("Sayı:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                    break;

                sayilar.Add(sayi);

            }

            sayilar.Sort();
            sayilar.Reverse();

            Console.WriteLine("En Büyük:"+sayilar[0]);
            Console.WriteLine("En Küçük:"+sayilar[sayilar.Count-1]);

            Console.ReadLine();
        }
    }
}
