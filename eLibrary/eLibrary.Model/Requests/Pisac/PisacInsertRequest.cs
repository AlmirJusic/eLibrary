using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.Pisac
{
    public class PisacInsertRequest
    {


        [Required(ErrorMessage = "Potrebno je unijeti ime pisca!")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti prezime pisca!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum rodjenja pisca!")]
        public DateTime DatumRodjenja { get; set; }
        public int Grad_ID { get; set; }
        

    }
}
