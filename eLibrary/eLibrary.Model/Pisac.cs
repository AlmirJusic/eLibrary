using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Pisac
    {
        public int Pisac_ID { get; set; }
        public string Ime { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int Grad_ID { get; set; }
        public virtual Grad Grad { get; set; }
    }
}
