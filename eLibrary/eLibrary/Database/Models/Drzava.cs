using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Drzava
    {
        [Key]
        public int Drzava_ID { get; set; }
        public string  NazivDrzave { get; set; }
    }
}
