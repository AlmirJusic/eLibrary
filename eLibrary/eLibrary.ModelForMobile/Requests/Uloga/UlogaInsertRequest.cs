using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.Uloga
{
    public class UlogaInsertRequest
    {


        [Required(ErrorMessage = "Potrebno je unijeti naziv uloge!")]
        public string? NazivUloge { get; set; }

        [Required(ErrorMessage = "Potrebno je unijeti opis uloge!")]
        public string? Opis { get; set; }

    }
}
