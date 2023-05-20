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

            DON:
            try
            {
                Console.WriteLine("yaşınız:");
                int yas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(yas/0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayısal Değer Giriniz!!...");
                goto DON;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 a bölemezsin!!");
                goto DON;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sayı 10 basamaktan büyük olmaz!!");
                goto DON;
            }
            catch (Exception e)
            {
                Console.WriteLine("Diğer hatalar"+e);
            }
                       

            Console.ReadLine();
        }
    }
}
