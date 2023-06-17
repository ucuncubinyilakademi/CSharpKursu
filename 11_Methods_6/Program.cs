using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Methods_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcnın girmiş oluduğu iki vize bir final notunun oratalamasını geri döndüren ortalamaya methodu ve ort göre geçme notu yazdıran programı kodlayınız.

            //ortalama = vize%30  final%40

            double v1 = 0, v2 = 0, f1 = 0;

            do
            {
                Console.WriteLine("Vize1:");
                v1 = Convert.ToDouble(Console.ReadLine());
            } while (NotKontrol(v1));
            do
            {
                Console.WriteLine("Vize1:");
                v2 = Convert.ToDouble(Console.ReadLine());
            } while (NotKontrol(v2));


            do
            {
                Console.WriteLine("Vize1:");
                f1 = Convert.ToDouble(Console.ReadLine());
            } while (NotKontrol(f1));

            double ort = Ortalama(v1, v2, f1);
            if (ort < 50)
            {
                Console.WriteLine("DD");
            }
            else if (ort < 80)
            {
                Console.WriteLine("CC");
            }
            else if (ort < 90)
            {
                Console.WriteLine("BB");
            }
            else
            {
                Console.WriteLine("AA");
            }

            Console.ReadLine();
        }

        static double Ortalama(double v1, double v2, double f1)
        {
            return v1*0.3+v2*0.3+f1*0.4;
        }

        static bool NotKontrol(double not)
        {
            if (not < 0 || not > 100)
                return true;

            return false;
        }

    }
}
