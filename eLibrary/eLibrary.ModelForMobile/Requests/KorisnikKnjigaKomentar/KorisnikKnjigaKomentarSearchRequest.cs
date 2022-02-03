using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.KorisnikKnjigaKomentar
{
    public class KorisnikKnjigaKomentarSearchRequest
    {
        public string? SadrzajKomentara { get; set; }
        public int? Knjiga_ID { get; set; }
    }
}
