using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class KorisnikKnjigaOcjena
    {
        public int KorisnikKnjigaOcjena_ID { get; set; }

        public double Ocjena { get; set; }
        public DateTime DatumOcjene { get; set; }

        public int Korisnik_ID { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }

    }
}
