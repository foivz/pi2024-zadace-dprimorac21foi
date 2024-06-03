using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusWay.Models
{
    public abstract class vozniRed : object
    {
        public int Id { get; set; }
        public string Datum { get; set; }
        public int VoznaLinijaId { get; set;}
    

    }
}
