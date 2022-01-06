using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class KnjigaZanr
    {
        [Key]
        public int KnjigaZanr_ID { get; set; }

        [ForeignKey(nameof(Knjiga))]
        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }

        [ForeignKey(nameof(Zanr))]
        public int Zanr_ID { get; set; }
        public virtual Zanr Zanr { get; set; }
    }
}
