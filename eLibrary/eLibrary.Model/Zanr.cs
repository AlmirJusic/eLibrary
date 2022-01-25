using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Zanr
    {
        public int Zanr_ID { get; set; }
        public string NazivZanra { get; set; }
        public override string ToString()
        {
            return NazivZanra;
        }
    }
}
