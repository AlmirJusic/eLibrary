using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.Knjiga
{
    public class KnjigaSearchRequest
    {
        public string? NazivKnjige { get; set; }
        public string? Pisac { get; set; }
        public int? Zanr_ID { get; set; }

    }
}
