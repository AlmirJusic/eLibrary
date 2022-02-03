using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile
{
    public class Knjiga
    {
        public int Knjiga_ID { get; set; }
        public string? NazivKnjige { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public byte[]? Slika { get; set; }
        public double Cijena { get; set; }
        public double Ocjena { get; set; }
        public string? PDF { get; set; }
        public string? Opis { get; set; }
        public bool PDFDodan { get; set; }

        public int Pisac_ID { get; set; }
        public virtual Pisac? Pisac { get; set; }
        public int Zanr_ID { get; set; }
        public virtual Zanr? Zanr { get; set; }

        public override string ToString()
        {
            return $"{NazivKnjige}";
        }

    }
}

