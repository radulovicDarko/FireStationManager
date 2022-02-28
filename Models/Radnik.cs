using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatrogasna_stanica.Models
{
    internal class Radnik
    {
        public string jmbg { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public int sifraRadnogMesta { get; set; }
        public string nazivRadnogMesta { get; set; }
    }
}
