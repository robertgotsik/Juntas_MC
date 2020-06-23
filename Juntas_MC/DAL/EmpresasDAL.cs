using Juntas_MC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntas_MC.DAL
{
    
    class EmpresasDAL
    {
        ConexionDAL conexion;
        public EmpresasDAL()
        {
            conexion = new ConexionDAL();
        }

        public DataSet mostrarEmpresa()
        {
            OleDbCommand sentencia = new OleDbCommand("Select top 1 * from Empresas");
            return conexion.ejecutarSentencia(sentencia);
        }

        public bool modificar(EmpresasBLL oEmpresasBLL)
        {
            if (oEmpresasBLL.Nombre != "")
            {
                return conexion.ejecutarMetodoSinRetornoDatos("UPDATE Empresas SET NOMBRE = '" + oEmpresasBLL.Nombre + "', Telefono = '" + oEmpresasBLL.Telefono +"', Email = '" +oEmpresasBLL.Email + "', Web = '" + oEmpresasBLL.Web + "', Direccion = '" + oEmpresasBLL.Direccion + "' where Id = 1");
            }
            else
            {
                return false;
            }
        }
    }
}
