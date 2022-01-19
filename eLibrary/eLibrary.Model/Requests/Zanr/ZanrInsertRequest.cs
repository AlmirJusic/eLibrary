using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.Zanr
{
    public class ZanrInsertRequest
    {
        [Required(ErrorMessage = "Potrebno je unijeti naziv žanra!")]

        public string NazivZanra { get; set; }
    }
}
