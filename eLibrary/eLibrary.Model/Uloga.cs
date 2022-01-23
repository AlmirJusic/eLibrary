using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Uloga
    {
        public int Uloga_ID { get; set; }
        public string NazivUloge { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return NazivUloge;
        }
    }
}
