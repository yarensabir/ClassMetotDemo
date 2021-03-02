using System;

// Engin Demiroğ - Yazılım Geliştirici Yetiştirme Kampı
// Gün 3 - Ödev 3

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Papiş";
            musteri1.Soyad = "Muhabbetgil";
            musteri1.ID = "0001";
            musteri1.yas = "0.6";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Miço";
            musteri2.Soyad = "Muhabbetgil";
            musteri2.ID = "001";
            musteri2.yas = "4";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Tospik";
            musteri3.Soyad = "Tospağagil";
            musteri3.ID = "0002";
            musteri3.yas = "100";

            MusteriManager MusteriIslemleri = new MusteriManager();
            MusteriIslemleri.MusteriEkle(musteri1);
            MusteriIslemleri.MusteriEkle(musteri2);
            MusteriIslemleri.MusteriEkle(musteri3);
            MusteriIslemleri.MusteriSil(musteri2);


        }
    }
}
