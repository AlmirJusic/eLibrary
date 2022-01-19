using eLibrary.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Grad
    {
        public int Grad_ID { get; set; }
        public string NazivGrada { get; set; }

        public int Drzava_ID { get; set; }
        public virtual Drzava Drzava { get; set; }
    }
}
