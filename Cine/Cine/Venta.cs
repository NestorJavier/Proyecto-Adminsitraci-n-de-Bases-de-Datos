using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Venta
    {
        public Int64 IdVenta { get; set; }
        public Int64 IdFuncion { get; set; }
        public Int64 IdMiembro { get; set; }
        public String Hora { get; set; }
        public Double Total { get; set; }

        public Venta()
        {

        }
        public Venta(Int64 IdVenta, Int64 IdFuncion, Int64 IdMiembro, String Hora, Double Total)
        {
            this.IdVenta = IdVenta;
            this.IdFuncion = IdFuncion;
            this.IdMiembro = IdMiembro;
            this.Hora = Hora;
            this.Total = Total;
        }
        public Venta(Int64 IdFuncion, Int64 IdMiembro, String Hora, Double Total)
        {
            this.IdFuncion = IdFuncion;
            this.IdMiembro = IdMiembro;
            this.Hora = Hora;
            this.Total = Total;
        }
        public int inserta()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Negocio.Venta(IdFuncion, IdMiembro, Hora, Total)" +
                              " Values({0}, {1}, '{2}', {3})",
                              this.IdFuncion, this.IdMiembro, this.Hora, this.Total), conn);

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
                string.Format("UPDATE Negocio.Venta SET IdFuncion = {0}, IdMiembro = {1}, Hora = '{2}', Total = {3} WHERE IdVenta = '{4}'",
                                this.IdFuncion, this.IdMiembro, this.Hora, this.Total, this.IdVenta), conn);

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
                string.Format("DELETE FROM Negocio.Venta WHERE IdVenta = '{0}'", this.IdVenta), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
    }
}
