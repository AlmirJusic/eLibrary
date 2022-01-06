using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Grad
    {
        [Key]
        public int Grad_ID { get; set; }
        public string NazivGrada { get; set; }

        [ForeignKey(nameof(Drzava))]
        public int Drzava_ID { get; set; }
        public virtual Drzava Drzava { get; set; }
    }
}
