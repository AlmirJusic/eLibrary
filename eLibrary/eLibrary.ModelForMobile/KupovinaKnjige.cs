using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile
{
    public class KupovinaKnjige
    {
        public int KupovinaKnjige_ID { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int Korisnik_ID { get; set; }
        public virtual Korisnik? Korisnik { get; set; }

        public int Knjiga_ID { get; set; }
        public virtual Knjiga? Knjiga { get; set; }

        public int NacinPlacanja_ID { get; set; }
        public virtual NacinPlacanja? NacinPlacanja { get; set; }
        
    }
}
