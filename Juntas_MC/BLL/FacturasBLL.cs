using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.BLL
{
    class FacturasBLL
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int Cliente { get; set; }
        public decimal ImporteTotal { get; set; }
    }
}
