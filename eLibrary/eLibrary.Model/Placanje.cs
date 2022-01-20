using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Placanje
    {
        public int Placanje_ID { get; set; }
        public int NacinPlacanja_ID { get; set; }
        public virtual NacinPlacanja? NacinPlacanja { get; set; }
        public double UkupnaCijena { get; set; }
        public string? ImePrezime { get; set; }
        public string? BrojKreditneKartice { get; set; }
        public string? CVV { get; set; }
        public DateTime DatumPlacanja { get; set; }
    }
}
