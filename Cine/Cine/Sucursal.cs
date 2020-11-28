using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Sucursal
    {
        public Int64 IdSucursal { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }

        public Sucursal()
        {

        }
        public Sucursal(Int64 IdSucursal, String Nombre, String Direccion)
        {
            this.IdSucursal = IdSucursal;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
        public Sucursal(String Nombre, String Direccion)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
        public int inserta()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Establecimiento.Sucursal(Nombre, Direccion)" +
                              " Values('{0}', '{1}')",
                              this.Nombre, this.Direccion), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
        public int actualiza()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Establecimiento.Sucursal SET Nombre = '{0}', Direccion = '{1}' WHERE IdSucursal = '{2}'",
                               this.Nombre, this.Direccion, this.IdSucursal), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

        public int elimina()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("DELETE FROM Establecimiento.Sucursal WHERE IdSucursal = '{0}'", this.IdSucursal), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

    }
}
