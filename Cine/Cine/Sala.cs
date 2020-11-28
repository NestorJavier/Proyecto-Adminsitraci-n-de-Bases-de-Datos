using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Sala
    {
        public Int64 IdSala { get; set; }
        public Int64 IdSucursal { get; set; }
        public int Numero { get; set; }
        public int CupoTotal { get; set; }

        public Sala()
        {

        }
        public Sala(Int64 IdSala, Int64 IdSucursal, int Numero, int CupoTotal)
        {
            this.IdSala = IdSala;
            this.IdSucursal = IdSucursal;
            this.Numero = Numero;
            this.CupoTotal = CupoTotal;
        }
        public Sala(Int64 IdSucursal, int Numero, int CupoTotal)
        {
            this.IdSucursal = IdSucursal;
            this.Numero = Numero;
            this.CupoTotal = CupoTotal;
        }
        public int inserta()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Establecimiento.Sala(IdSucursal, Numero, CupoTotal)" +
                              " Values({0}, {1}, {2})",
                              this.IdSucursal, this.Numero, this.CupoTotal), conn);

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
                string.Format("UPDATE Establecimiento.Sala SET IdSucursal = {0}, Numero = {1}, CupoTotal = {2} WHERE IdSala = '{3}'",
                                this.IdSucursal, this.Numero, this.CupoTotal, this.IdSala), conn);

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
                string.Format("DELETE FROM Establecimiento.Sala WHERE IdSala = '{0}'", this.IdSala), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

    }
}
