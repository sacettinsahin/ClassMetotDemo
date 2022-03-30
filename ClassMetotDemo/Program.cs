using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Ad = "Sacettin";
            musteri1.Soyad = "ŞAHİN";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Kemal";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Yıldız";

            Musteri musteri4 = new Musteri();
            musteri4.ID = 4;
            musteri4.Ad = "Melih";
            musteri4.Soyad = "Özdilek";

            Musteri[] musteriler = new Musteri[]{musteri1,musteri2,musteri3,musteri4};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID : " +musteri.ID);
                Console.WriteLine("Müşteri Adı : " +musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " +musteri.Soyad);
                Console.WriteLine("---------------------");
            }

            MusteriManager musteriIslem = new MusteriManager();
            musteriIslem.Ekle(musteri1);
            musteriIslem.Cikar(musteri2);
            musteriIslem.Listele(musteri3);
            musteriIslem.Listele(musteri4);
        }
    }
}
