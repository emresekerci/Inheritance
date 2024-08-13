using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public void KisiBilgisi()
        {
            Console.WriteLine($"İsim: {Ad}");
            Console.WriteLine($"Soyisim: {Soyad}");
        }
    }
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }
        public void OgrenciBilgi()
        {
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
            KisiBilgisi();
        }




    }
    public class Ogretmen : BaseKisi
    {
        public decimal MaasBilgisi { get; set; }
        public void OgretmenBilgi()
        {
            Console.WriteLine($"Maaş: {MaasBilgisi}");
            KisiBilgisi();
        }

    }

}