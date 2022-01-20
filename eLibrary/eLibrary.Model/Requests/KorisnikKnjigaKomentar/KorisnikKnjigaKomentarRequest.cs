using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLibrary.Model;

namespace eLibrary.Model.Requests.KorisnikKnjigaKomentar
{
    public class KorisnikKnjigaKomentarRequest
    {
        public int KorisnikKnjigaKomentar_ID { get; set; }
        public string SadrzajKomentara { get; set; }
        public DateTime DatumKomentara { get; set; }

      
        public int Korisnik_ID { get; set; }
        public eLibrary.Model.Korisnik Korisnik { get; set; }

        public int Knjiga_ID { get; set; }
    }
}
