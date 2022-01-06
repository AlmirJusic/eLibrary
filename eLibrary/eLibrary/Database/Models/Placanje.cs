using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Placanje
    {
        [Key]
        public int Placanje_ID { get; set; }
        public double UkupnaCijena { get; set; }
        
        [ForeignKey(nameof(NacinPlacanja))]
        public int NacinPlacanja_ID { get; set; }
        public virtual NacinPlacanja NacinPlacanja { get; set; }

#nullable enable
        public string? ImePrezime { get; set; }
#nullable enable
        public string? BrojKreditneKartice { get; set; }
#nullable enable 
        public string? CVV { get; set; }
#nullable enable
        public DateTime DatumPlacanja { get; set; }
    }
}
