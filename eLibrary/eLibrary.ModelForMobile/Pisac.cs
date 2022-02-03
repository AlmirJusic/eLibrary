using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile
{
    public class Pisac
    {
        public int Pisac_ID { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int Grad_ID { get; set; }
        public virtual Grad? Grad { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        
        public string ImePrezime => $"{Ime} {Prezime}";

    }
}
