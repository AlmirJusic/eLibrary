using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class KorisnikKnjigaOcjena
    {
        [Key]
        public int KorisnikKnjigaOcjena_ID { get; set; }
        public double Ocjena { get; set; }
        public DateTime DatumOcjene { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int Korisnik_ID { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        [ForeignKey(nameof(Knjiga))]
        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }
    }
}
