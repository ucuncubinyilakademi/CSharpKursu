using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList sozluk = new SortedList() {
            //    {"Bugun","Today"},
            //    {"Yarin","Tommorrow"},
            //    {"Hava","Wheather" },
            //    {"Gokyuzu","Sky" },
            //    {"Karli","Snowy" },
            //    {"Gunesli","Sunny" },
            //    {"Bulutlu","Cloudy" },
            //    {"Acik","Clear" },
            //    {"Kapali","Cloudy"},
            //};

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item.Key+":"+item.Value);
            //}


            //Hashtable tanımlama


            //LIFO: Last in first out
            Hashtable htable = new Hashtable();
            Console.WriteLine($"Count :{htable.Count}");

            //Add metodu
            htable.Add(1, "Bir");
            htable.Add(2, "İki");
            htable.Add(3, "Üç");
            htable.Add(4, "Dört");
            htable.Add("Beş", "5");

            //Ekrana yazdırma 
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Key + "     " + item.Value);
                //Console.WriteLine(((DictionaryEntry)item).);
            }


            Console.ReadLine();
        }
    }
}
