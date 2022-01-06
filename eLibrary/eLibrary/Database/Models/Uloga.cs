using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Uloga
    {
        [Key]
        public int Uloga_ID { get; set; }
        public string NazivUloge { get; set; }
        public string Opis { get; set; }
    }
}
