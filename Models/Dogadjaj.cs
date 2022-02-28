using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class Dogadjaj
    {
        public int sifra { get; set; }
        public string opis { get; set; }
        public string mesto { get; set; }
        public string adresa { get; set; }
        public string velicina { get; set; }
        public string ugrozenostLjudiDogadjaja { get; set; }
    }
}
