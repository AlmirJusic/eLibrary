using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Knjiga
    {
        public int Knjiga_ID { get; set; }
        public string NazivKnjige { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public double Ocjena { get; set; }
        public string PDF { get; set; }
        public string Opis { get; set; }
        public bool PDFDodan { get; set; }
    }
}
