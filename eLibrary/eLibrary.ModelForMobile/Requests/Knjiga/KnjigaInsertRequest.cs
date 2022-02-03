using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.Knjiga
{
    public class KnjigaInsertRequest
    {


        [Required(ErrorMessage = "Potrebno je unijeti naziv knjige!")]
        public string? NazivKnjige { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum izdavanja knjige!")]
        public DateTime DatumIzdavanja { get; set; }

        public byte[]? Slika { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti cijenu knjige!")]
        public double Cijena { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti ocjenu knjige!")]
        public double Ocjena { get; set; }

        public string? PDF { get; set; }
        public string? Opis { get; set; }
        public bool PDFDodan { get; set; }

        
        public int Pisac_ID { get; set; }
        public int Zanr_ID { get; set; }

    }
}
