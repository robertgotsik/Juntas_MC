using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.BLL
{
    class PiezasBLL
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int PiezaTipo { get; set; }
        public int Material { get; set; }
        public string Detalles { get; set; }
        public string Imagen { get; set; }
        public int Estado { get; set; }
    }
}
