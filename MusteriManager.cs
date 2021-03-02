using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        char cevap;
        public void MusteriEkle(Musteri newMusteri)
        {
            Console.WriteLine(newMusteri.Ad +" "+ newMusteri.Soyad +" isimli musteri kaydi basariyla tamamlanmıstır.");
        }
        public void MusteriSil(Musteri newMusteri)
        {
            Console.WriteLine(newMusteri.Ad + " " + newMusteri.Soyad + " isimli musterimizin kaydi silinmistir.");
        }
        //müşteri listeleme metodu eksik


    }
}
