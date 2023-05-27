using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  TRY CATCH : HATA YAKALAMA */
            //try
            //{
            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi/0);
            //}
            //catch
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}

            try
            {
                Console.WriteLine("yaşınız:");
                int yas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(yas / 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayısal Değer Giriniz!!...");                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 a bölemezsin!!");                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sayı 10 basamaktan büyük olmaz!!");                
            }
            catch (Exception e)
            {
                Console.WriteLine("Diğer hatalar" + e);
            }


            Console.ReadLine();
        }
    }
}
