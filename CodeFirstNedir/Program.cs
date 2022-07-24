using CodeFirstNedir.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeData;

namespace CodeFirstNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Context db = new Context();
            //db.Database.Create();
            //Context.VarlıkKontrol();

            for (int i = 0; i < 10; i++)
            {
                Firma f = new Firma();
                f.Id = Guid.NewGuid();
                f.Unvan = NameData.GetCompanyName();
                f.Telefon1 = PhoneNumberData.GetPhoneNumber();
                f.Telefon2 = PhoneNumberData.GetPhoneNumber();
                f.WebAdres = $"www.{f.Unvan.ToLower()}.com";
                f.EmailAdres = $"info@{f.Unvan.ToLower()}.com";
                int sonuc = FirmaKayitEkle(f);


                for (int j = 0; j < 30; j++)
                {

                    Kisi k = new Kisi();
                    k.Id = Guid.NewGuid();
                    k.Isim = NameData.GetFirstName();
                    k.Soyisim = NameData.GetSurname();
                    k.Telefon1 = PhoneNumberData.GetPhoneNumber();
                    k.Telefon2 = PhoneNumberData.GetPhoneNumber();
                    k.EmailAdres = $"{k.Isim}.{k.Soyisim}@{f.Unvan.ToLower()}.com";
                    k.DoğumTarihi = DateTimeData.GetDatetime(new DateTime(1960, 01, 01), new DateTime(1990, 01, 01));
                    k.Ulke = PlaceData.GetCountry();
                    k.Il = PlaceData.GetCity();
                    k.Ilce = PlaceData.GetCounty();
                    KisiKayitEkle(k);
                }
            }
        }
        public static int FirmaKayitEkle(Firma firma)
        {
            int sonuc = 0;
            using (Context ctx = new Context())
            {
                ctx.Firma.Add(firma);
                sonuc = ctx.SaveChanges();
            }
            return sonuc;
        }

        public static int KisiKayitEkle(Kisi kisi)
        {
            int sonuc = 0;
            using (Context ctx = new Context())
            {
                ctx.Kisi.Add(kisi);
                sonuc = ctx.SaveChanges();
            }
            return sonuc;
        }
        public static int KullaniciKayitEkle(Kullanici kullanici)
        {
            int sonuc = 0;
            using (Context ctx = new Context())
            {
                ctx.Kullanici.Add(kullanici);
                sonuc = ctx.SaveChanges();
            }
            return sonuc;
        }


    }
}
