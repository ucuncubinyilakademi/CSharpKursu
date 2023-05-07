using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime tarihZaman = new DateTime();  //DateTime isminde bir sınıf var bu sınıftan bir örnek alma işlemi.
            Console.WriteLine(tarihZaman);

            DateTime tarih = DateTime.Now;

            Console.WriteLine(tarih);
            Console.WriteLine(tarih.Year);
            Console.WriteLine(tarih.Month);
            Console.WriteLine(tarih.Day);
            Console.WriteLine(tarih.Hour);
            Console.WriteLine(tarih.Minute);
            Console.WriteLine(tarih.Second);
            Console.WriteLine(tarih.Millisecond);
            Console.WriteLine(tarih.Date);
            Console.WriteLine(tarih.AddYears(5));
           

            DateTime dateTime = new DateTime(2023,05,07,13,28,56);
            Console.WriteLine(dateTime);
             */


            //******* DATETIME FORMATLAMA *************

            Thread.Sleep(3000);

            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.ToString("d"));
            Console.WriteLine(tarih.ToString("D"));
            Console.WriteLine(tarih.ToString("dddd"));
            Console.WriteLine(tarih.ToString("ddd"));
            Console.WriteLine(tarih.ToString("dd"));


            Console.ReadKey();
        }
    }
}
