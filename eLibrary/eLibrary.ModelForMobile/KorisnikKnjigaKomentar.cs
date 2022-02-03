using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile
{
    public class KorisnikKnjigaKomentar
    {
        public int KorisnikKnjigaKomentar_ID { get; set; }
        public string? SadrzajKomentara { get; set; }
        public DateTime DatumKomentara { get; set; }

        public int Korisnik_ID { get; set; }
        public virtual Korisnik? Korisnik { get; set; }

        public int Knjiga_ID { get; set; }
        public virtual Knjiga? Knjiga { get; set; }

    }
}
