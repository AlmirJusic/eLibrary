using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class KnjigaPisac
    {
        [Key]
        public int KnjigaPisac_ID { get; set; }

        [ForeignKey(nameof(Knjiga))]
        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }

        [ForeignKey(nameof(Pisac))]
        public int Pisac_ID { get; set; }
        public virtual Pisac Pisac { get; set; }
    }
}
