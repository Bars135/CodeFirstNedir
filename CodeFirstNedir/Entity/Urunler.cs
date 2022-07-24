using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNedir.Entity
{
    public class Urunler
    {

        //Eğer biz Id olan alanımıza key ataması yapmazsak tablomus oluşmmayacaktır.
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }


    }
}
