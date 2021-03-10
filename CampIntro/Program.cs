using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYaptımı = true;
            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Deger Kaybetti");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar Deger Kazandı");

            }
            else
            {
                Console.WriteLine("Herhangi Bir Değişim Yaşanmadı");
            }
            if (sistemeGirisYaptımı==true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("GirisYap Butonu");
            }
        }
    }
}
