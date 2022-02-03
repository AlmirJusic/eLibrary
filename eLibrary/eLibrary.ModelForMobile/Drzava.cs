using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ModelForMobile
{
    public class Drzava
    {
        public int Drzava_ID { get; set; }
        public string? NazivDrzave { get; set; }
        public override string ToString()
        {
            return $"{NazivDrzave}";
        }
    }
}
