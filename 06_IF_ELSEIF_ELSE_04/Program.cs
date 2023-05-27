using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IF_ELSEIF_ELSE_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınacak 3 adet sayının içinde
            //2'nin katları olan sayıların 
            //toplamını yapınız ve kullanıcıya gösteriniz

            
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.Sayı:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            if (s1 % 2 == 0)
            {
                toplam += s1;
            }
            if (s2 % 2 == 0)
            {
                toplam += s2;
            }
            if (s3 % 2 == 0)
            {
                toplam += s3;
            }

            Console.WriteLine("Toplam="+toplam);

            

            Console.ReadLine();

        }
    }
}
