using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.Drzava
{
    public class DrzavaInsertRequest
    {


        [Required(ErrorMessage = "Potrebno je unijeti naziv drzave!")]

        public string? NazivDrzave { get; set; }

    }
}
