using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Knjiga
    {
        
        [Key]
        public int Knjiga_ID { get; set; }
        public string NazivKnjige { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public double Ocjena { get; set; }
        public string PDF { get; set; }
        public string Opis { get; set; }
        public bool PDFDodan { get; set; }

        [ForeignKey(nameof(Pisac))]
        public int Pisac_ID { get; set; }
        public virtual Pisac Pisac { get; set; }

        [ForeignKey(nameof(Zanr))]
        public int Zanr_ID { get; set; }
        public virtual Zanr Zanr { get; set; }



    }
}
