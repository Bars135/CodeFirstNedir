using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNedir.Entity
{
    public class Firma
    {
        [Key]
        public Guid Id { get; set; }
        public string Unvan { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string WebAdres { get; set; }
        public string EmailAdres { get; set; }

        public ICollection<Kisi> Kisiler { get; set; }  

    }
}
