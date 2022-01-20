using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class KnjigaPisac
    {
        public int KnjigaPisac_ID { get; set; }

        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }

        public int Pisac_ID { get; set; }
        public virtual Pisac Pisac { get; set; }

    }
}
