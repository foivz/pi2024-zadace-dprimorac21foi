using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWay.Models
{
    internal class VoznaLinija
    {
        public int Id { get; set; }
        public string Odrediste { get; set; }
        public string Polaziste { get; set; }
        public DateTime VrijemePolaska = new DateTime();


    }
}
