using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWay.Models
{

    public class VoznaLinija
    {
        public int Id { get; set; }
        public string ImeLinije { get; set; }
        public string Polaziste { get; set; }
        public string Dolaziste { get; set; }
        public DateTime Datum { get; set; }
    }
}
