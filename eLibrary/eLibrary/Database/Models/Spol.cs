using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database.Models
{
    public class Spol
    {
        [Key]
        public int Spol_ID { get; set; }
        public string OznakaSpola { get; set; }
    }
}
