using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.ModelForMobile.Requests.NacinPlacanja
{
    public class NacinPlacanjaInsertRequest
    {
        [Required(ErrorMessage = "Potrebno je unijeti nacin placanja!")]
        public string? Naziv { get; set; }
    }
}
