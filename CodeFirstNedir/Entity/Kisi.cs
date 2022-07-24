using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNedir.Entity
{
    public class Kisi
    {
        [Key]
        public Guid Id { get; set; }
        public string Isim { get; set; }


        public string Soyisim { get; set; }
        public DateTime DoğumTarihi { get; set; }

        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string EmailAdres { get; set; }

        public Firma Firma { get; set; }



    }
}
