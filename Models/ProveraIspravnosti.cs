using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class ProveraIspravnosti
    {
        public int evidencijskiBroj { get; set; }
        public DateTime datumKontrolisanja { get; set; }
        public string ocenaIspravnosti { get; set; }
        public string fabrickiBroj { get; set; }
        public string jmbgRadnika { get; set; }
        public DateTime datumIstekaKontrole { get; set; }
    }
}
