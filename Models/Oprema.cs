using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class Oprema
    {
        public string fabrickiBroj { get; set; }
        public int masa { get; set; }
        public DateTime datumProizvodnje { get; set; }
        public string nazivProizvodjaca { get; set; }
        public int sifraOpreme { get; set; }
    }
}
