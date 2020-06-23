using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.BLL
{
    class FacturasItemsBLL
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int PiezaId {get;set;}
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal ItemImporteTotal { get; set; }
    }
}
