using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.PrijedlogKnjige
{
    public class PrijedlogKnjigeInsertRequest
    {
        public string? NazivPrijedlogaKnjige { get; set; }
        public string? Opis { get; set; }
        public DateTime DatumPrijedloga { get; set; }
        public bool Odgovoren { get; set; }
        public bool Pregledan { get; set; }
        public int Korisnik_ID { get; set; }
    }
}
