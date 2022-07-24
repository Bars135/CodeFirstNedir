using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNedir.Entity
{
    public class Kullanici
    {

        [Key]
        public Guid KullaniciID { get; set; }   
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Sifre { get; set; }
        public int BirimFiyati { get; set; }
        public int BirimdekiMiktar { get; set; }


    }
}
