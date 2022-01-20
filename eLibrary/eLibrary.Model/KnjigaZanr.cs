using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class KnjigaZanr
    {
        public int KnjigaZanr_ID { get; set; }

        public int Knjiga_ID { get; set; }
        public virtual Knjiga Knjiga { get; set; }

        public int Zanr_ID { get; set; }
        public virtual Zanr Zanr { get; set; }
    }
}
