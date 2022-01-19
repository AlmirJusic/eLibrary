using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Korisnik
    {
        public int Korisnik_ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public int Spol_ID { get; set; }
        public virtual Spol Spol { get; set; }

        public int Grad_ID { get; set; }
        public virtual Grad Grad { get; set; }

        public int Uloga_ID { get; set; }
        public virtual Uloga Uloga { get; set; }

        public string Username { get; set; }
    }
}
