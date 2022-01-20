using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.KorisnikKnjigaOcjena
{
    public class KorisnikKnjigaOcjenaRequest
    {
        public int KorisnikKnjigaOcjena_ID { get; set; }
        public double Ocjena { get; set; }
        public DateTime DatumOcjene { get; set; }
        public int Korisnik_ID { get; set; }
        public int Knjiga_ID { get; set; }
    }
}
