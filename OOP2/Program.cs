using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "34252";
            musteri1.Adi = "Doğa";
            musteri1.Soyadi = "Güven";
            musteri1.TcNo = "46757307228";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45752";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";
            //Gerçek Müşteri-Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
