using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class PrijedlogKnjige
    {
        [Key]
        public int PrijedlogKnjige_ID { get; set; }
        public string NazivPrijedlogaKnjige { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPrijedloga { get; set; }
        public bool Odgovoren { get; set; }
        public bool Pregledan { get; set; }

        [ForeignKey(nameof(Korisnik))]
        public int Korisnik_ID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
