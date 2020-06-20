using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.BLL
{
    class PreciosMercadosBLL
    {
        public int Id { get; set; }
        public int PiezaId { get; set; }
        public int Mercado { get; set; }
        public decimal Precio { get; set; }
        public int Estado { get; set; }
    }
}
