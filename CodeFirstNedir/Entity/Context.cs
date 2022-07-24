using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNedir.Entity
{
    public class Context:DbContext
    {


        //public Context():base()
        //{
        //    Console.WriteLine($"Database Yolu: {Database.Connection.ConnectionString}");

        //}

        //Varlıkk Kontrol

        public static void VarlıkKontrol()
        {
            using(Entity.Context db=new Entity.Context())
            {
                bool Kontrol = db.Database.Exists();
                if (Kontrol)
                {
                    Console.WriteLine($"Database Yolu : {db.Database.Connection.ConnectionString}");
                }
                else
                {
                    Console.WriteLine($"Böyle bir database yolu mevcut değildir.");
                }
            }
        }


        //DbCOntext : uygulama ile veri tabanı arasında bağantı kurma işlemini yapar
        //DbSet : Context sınıfının işlemleri yani kısaca veri tabanını yönetir Model ile ilişkili ayarlar Değişiklikleri yönetir caching Transaction yönetimi yapar Object metarilazasyon veri tabanından aldığı verileri entity nesnesine dönüştürür.
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet <Firma> Firma { get; set; }
        public DbSet <Kisi> Kisi { get; set; }
        public DbSet <Kullanici> Kullanici { get; set; }














    }
}
