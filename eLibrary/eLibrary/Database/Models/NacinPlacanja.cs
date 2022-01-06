using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class NacinPlacanja
    {
        [Key]
        public int NacinPlacanja_ID { get; set; }
        public string Naziv { get; set; }
    }
}
