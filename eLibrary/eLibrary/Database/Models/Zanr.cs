using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Zanr
    {
        [Key]
        public int Zanr_ID { get; set; }
        public string NazivZanra { get; set; }
    }
}
