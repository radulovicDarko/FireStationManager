using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class UpucivanjeLjudstvaVozila
    {
        public DateTime datumUpucivanja { get; set; }
        public string vremeIzlaska { get; set; }
        public string opis { get; set; }
        public string vremeStizanja { get; set; }
        public string vremeLikvidacije { get; set; }
        public string vremeLokalizacije { get; set; }
        public string registarskiBrojVozila { get; set; }
        public string jmbgRadnika { get; set; }
        public string sifraDogadjaja { get; set; }
    }
}
