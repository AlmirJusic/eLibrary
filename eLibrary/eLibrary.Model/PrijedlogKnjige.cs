using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class PrijedlogKnjige
    {
        public int PrijedlogKnjige_ID { get; set; }
        public string NazivPrijedlogaKnjige { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPrijedloga { get; set; }
        public bool Odgovoren { get; set; }
        public bool Pregledan { get; set; }
        public int Korisnik_ID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
