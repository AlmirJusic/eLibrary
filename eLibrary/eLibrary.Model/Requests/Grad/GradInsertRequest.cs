using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model.Requests.Grad
{
    public class GradInsertRequest
    {


        [Required(ErrorMessage = "Potrebno je unijeti naziv grada!")]

        public string NazivGrada { get; set; }
        public int Drzava_ID { get; set; }

    }
}
