using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.KupovinaKnjige
{
    public class KupovinaKnjigeInsertRequest
    {
        public DateTime DatumKupovine { get; set; }
        public int Korisnik_ID { get; set; }
        public int Knjiga_ID { get; set; }
        public bool Odobreno { get; set; }

    }
}
