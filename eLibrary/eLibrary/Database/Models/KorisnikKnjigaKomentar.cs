using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class KorisnikKnjigaKomentar
    {
        [Key]
        public int Komentar_ID { get; set; }
        public string SadrzajKomentara { get; set; }
        public DateTime DatumKomentara { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int Korisnik_ID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        [ForeignKey(nameof(Knjiga))]
        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }
    }
}
