using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class PrijavljivanjeDogadjaja
    {
        public int sifra { get; set; }
        public DateTime datum { get; set; }
        public string imePrezimeDojavio { get; set; }
        public string telefonDojavio { get; set; }
        public string napomena { get; set; }
        public string jmbgRadnika { get; set; }
        public string sifraDogadjaja { get; set; }
    }
}
