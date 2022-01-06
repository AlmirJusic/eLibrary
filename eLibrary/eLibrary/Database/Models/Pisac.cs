using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Pisac
    {
        [Key]
        public int Pisac_ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }


        [ForeignKey(nameof(Grad))]
        public int Grad_ID { get; set; }
        public virtual Grad Grad { get; set; }
    }
}
