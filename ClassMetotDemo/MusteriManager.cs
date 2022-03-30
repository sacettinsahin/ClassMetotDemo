using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Listeye eklenen müşteri : "+musteri.Ad +" " +musteri.Soyad);
            Console.WriteLine("*****************************");
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine("Listeden çıkarılan müşteri : "+musteri.Ad +" "+ musteri.Soyad);
            Console.WriteLine("*****************************");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " ID'li Müşteri Bilgileri;");
            Console.WriteLine("Müşteri ID : " +musteri.ID);
            Console.WriteLine("Müşteri Adı : " +musteri.Ad);
            Console.WriteLine("Müşteri Soyadı : " +musteri.Soyad);
            Console.WriteLine("----------------------------");
            
        }
    }
}
