using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tek satır açıklama yazmaya yarar.

            /*
            Birden fazla satır açıklama yazılabilir.
            Comment(Yorum) satırlar derleyici(compiler)-Visual Studio tarafından kontrol edilmez.
            Comment yazmaktaki amacımız kendimize veya başka yazılımcılara not bırakmaktır.
            */

            /*
            Solution Explorer => Projeleri ve dosyalarını listeler.
                                 View -> Solution Explorer açabilirsiniz.

            Proje Açma => New Project => Console App(C# .Net Framework olmasına dikkat ediyoruz.)
            Solution => Birden fazla projeyi altında barındırabilen yapıdır.
                        Kapsadığı projelerin birbirlerini tanımasını ve senkronize olarak iletişim kurmasını sağlar.


            .NET FRAMEWORK NEDİR?
                .NET microsoft firmasına ait yazılımların yazılabildiği kontrol(yazım kuralları) edildiği bir yapıdır.
                .NET Framework ise Microsoft firmasına ait bütün dillerin ve yapıların birlikte geliştirilebilceği ve çalıştırılabileceği bir platformdur.
                        C#      => Console ve Masaüstü
                        MSSQL   => Veritabanı yazılımı
                        ASP.NET => Web Yazılım
                        Unity   => Oyun Programlama
                        Azure   => Bulut Tabanlı Veri Tabanı
                        Xamarin => Mobil Yazılım
                        Web Service 

            Algoritma: Bir sorunu çözmek veya belirlenmiş bir hedefe ulaşmak için gerçekleştirilen işlemin işlem adımlarıdır.
            Amaca ulaşmak için işlenecek yolları ve sıralamalarını belirli bir mantıkla takip etmemezi sağlar.

            Giriş/Çıkış Bilgisi: Program başlangıcında verilecek değerleri veya kullanıcıdan dışarıdan alınacak değerlerin  neler    olduğu ve işlemler sonucunda ne çıktısı alınacağının belirtilmiş olması gereklidir.

            Sonluluk: Her türlü olasılık bir sonuca ulaşmalıdır.Ucu açık bir durum kalmamalıdır. 

            Kesinlik: Her komutun(işlem) net bir şekilde yapacağı iş belirtilmelidir.

            Etkinlik: Yazılan algoritmalar etkin ve dolasıyla gereksiz tekrarlandan kaçınmalıdır. Algoritma genellenebilir ve modüler olmalıdır. 

            Başarı ve Performans: Amaça ulaşılmalı ve algoritma paradan,zamandan ve performanstan kazanç sağlamalıdır.
            */

            /*
             * 
             * ÇAY DEMLEME
            1.Başla
            2.Mutfağa Git
            3.Çaydanlığa Su Koy
            4.Ocağı Yak
            5.Su Kaynadı Mı? E->7 H->6
            6.Bekle ->5
            7.Demliğe Çay Koy
            8.Çaydanlığa Su Koy
            9.Çay Demlendi Mi? E->11
            10.Bekle ->9
            11.Servis Et
            12.Bitti
                         
             
            ** Su Kesikse
            ** Çay Yoksa
             
            
            1.Başla
            2.Mutfağa Git
            3.Su veya Çay Var Mı? E->9 H->4
            4.Bakkala Git
            5.Bakkal Açık Mı? E->7 H->6
            6.Başka Bakkala Git ->5
            7.Eksikleri Al
            8.Eve Dön -> 2
            9.Çaydanlığa Su Koy
            10.Ocağı Yak
            11.Su Kaynadı Mı? E->13 
            12.Bekle ->11
            13.Demliğe Çay Koy
            14.Çaydanlığa Su Koy
            15.Çay Demlendi Mi? E->17
            16.Bekle ->15
            17.Servis Et
            18.Bitti
             */

            /* 
            1.Başla
            2.Daireden Çık
            3.Asansör Mü? Merdiven Mi? A->4 M->11
            4.Asansör Katta Mı? E->6 H->5
            5.Çağır ->4
            6.Asansöre Bin
            7.İstenilen Katın Tuşuna Bas
            8.Asansör İstenilen Katta Mı? E->10
            9.Bekle ->8
            10.Asansörden İn ->13
            11.1.Kat Hareket
            12.İstenilen Katın.Katta Mıyız? H->11
            13.Binadan Çık
            14.Akbili Var Mı? E->17
            15.Büfeye Git 
            16.Akbil Doldur
            17.Durağa Git
            18.Toplu Taşıma Geldi Mi? E->20
            19.Bekle ->18
            20.Toplu Taşımaya Bin
            21.Akbil Bas
            22.Boş Yer Var Mı? H->24
            23.Otur ->25
            24.Ayakta Git
            25.İstenilen Durağa Geldi Mi? E->27
            26.Bekle ->25
            27.Toplu Taşımadan İn
            28.Akademiye Yürü
            29.Bitti
             */



        }
    }
}
