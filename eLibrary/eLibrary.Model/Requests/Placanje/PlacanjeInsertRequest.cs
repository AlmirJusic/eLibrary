using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.Placanje
{
    public class PlacanjeInsertRequest
    {
        [Required(ErrorMessage = "Potrebno je unijeti ukupnu cijenu!")]
        public double UkupnaCijena { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti nacin placanja!")]
        public int NacinPlacanja_ID { get; set; }
        public string? ImePrezime { get; set; }
        public string? BrojKreditneKartice { get; set; }
        public string? CVV { get; set; }
        public DateTime DatumPlacanja { get; set; }

    }
}
