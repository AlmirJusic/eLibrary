using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class Spol
    {
        public int Spol_ID { get; set; }
        public string OznakaSpola { get; set; }
        public override string ToString()
        {
            return OznakaSpola;
        }
    }
}
